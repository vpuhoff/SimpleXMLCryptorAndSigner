﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //Получение и установка тестового сертификата http://www.cryptopro.ru/certsrv/, если будет ошибка нужно добавить сайт в "Надежные сайты", и для этой зоны разрешить установку ActiveX
        //Проверка подписи подписанного документа http://dss.cryptopro.ru/notary/VerifyDetachedSignature.aspx
        //Для подписи нужен криптопровайдер КриптоПро CSP или его аналог, скачать можно например тут http://www.cryptopro.ru/system/files/private/csp/39/8227/CSPSetup.exe
        //Чтобы каждый раз не спрашивал пароль от сертификата нужно нажать галочку "сохранить пароль"
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
           
        }

        string GetBase64(byte[] data)
        {
           return  Convert.ToBase64String(data);
        }

        byte[] GetDataFromBase64(string data)
        {
            return Convert.FromBase64String(data);
        }
        /// <summary>
        /// Подписание содержимого указанным сертификатом
        /// </summary>
        /// <param name="certificateforsign">Сертификат, с которым связан ключ для подписания.</param>
        /// <param name="data">Подписываемое содержимое.</param>
        /// <param name="SignedDataWithoutEncrypt">Файл с ЭП для КриптоПРО без шифрования.</param>
        /// <param name="silent">Запрос на подписание (в том числе требование ПИН кода).</param>
        /// <returns>Подпись.</returns>
        public byte[] SignAndEncode(byte[] data, out byte[] SignedDataWithoutEncrypt, X509Certificate2 certificateforsign = null, X509Certificate2 certificateforencrypt = null, bool silent = false)
        {
            // то что подписываем 
            var contentInfo = new ContentInfo(data);
            var cmsSigner = new CmsSigner(SubjectIdentifierType.IssuerAndSerialNumber, certificateforsign);
            SignedCms signedCms;
            byte[] SignedData;

                //Создаем файл с отсоединенной подписью для КриптоПро
                signedCms = new SignedCms(contentInfo, true);
                // подписание в бесшумном режиме (silent = true)
                try
                {
                    signedCms.ComputeSignature(cmsSigner, true );
                }
                catch (Exception)
                {
                    signedCms.ComputeSignature(cmsSigner, false);
                }
                
                // подпись в формате CMS/PKCS 7
                SignedDataWithoutEncrypt = signedCms.Encode();  // только файл полученный на данном этапе можно проверять сервисом по ссылке в начале кода, далее идет его шифрование
                //отдаем файл только с подписью, оставил для демонастрации возможности проверить ЭП на сайте КриптоПро

            //Создаем файл с подсоединенной подписью для шифрования
            signedCms = new SignedCms(contentInfo, false );
            // подписание в бесшумном режиме (silent = true) 
            signedCms.ComputeSignature(cmsSigner, false);
            // подпись в формате CMS/PKCS 7
            SignedData = signedCms.Encode(); 
            // шифрование сообщения выбранным сертификатом (может отличаться от первого сертификата)
            EnvelopedCms envelopedCms = new EnvelopedCms();
          
            // сохраняем файл в Base64, чтобы не нарушить подписи при шифровании
            string b64data = GetBase64(SignedData);
            SignedData = Encoding.ASCII.GetBytes(b64data);
            var SignedContent = new ContentInfo(SignedData);
            envelopedCms = new EnvelopedCms(SubjectIdentifierType.IssuerAndSerialNumber, SignedContent);
            X509Certificate2 recpsert;
            if (certificateforencrypt==null )
            {
               recpsert= GetSert("Сертификат получателя","Выберите сертификат получателя (который будет использоваться для расшифровки)");
            }
            else
            {
                recpsert = certificateforencrypt;
            }
            CmsRecipient recp= new CmsRecipient(recpsert);
            envelopedCms.Encrypt(recp);
            return envelopedCms.Encode();
        }

        public class Sign
        {
            public Sign(SignerInfo signer)
            {
                Signer = signer.Certificate.Subject;
                Cert = signer.Certificate;
            }
            public string FileName { get; set; }
            public string Signer { get; set; }
            public string Result { get; set; }
            public X509Certificate2 Cert { get; set; }
        }

        /// <summary>
        /// Расшифровка и проверка подписи сертификата
        /// </summary>
        /// <param name="certificate">Сертификат, с которым связан ключ для подписания.</param>
        /// <param name="data">Шифрованное содержимое.</param>
        /// <param name="dec">Расшифрованный документ.</param>
        /// <param name="signInfo">Массив подписей.</param>
        /// <param name="CheckSignatureOnly">Определяет требуется ли проверка целостности или еще и проверка подлинности. В случае значения false будет производиться проверка подлинности у УЦ</param>
        /// <returns>Данные о сертификатах, которыми подписан документ и сам расшифрованный документ.</returns>
        public bool Decrypt(byte[] data, out byte[] dec, out Sign[] signInfo,bool CheckSignatureOnly=true )
        {
            EnvelopedCms envelopedCms = new EnvelopedCms();
            try
            {
               envelopedCms.Decode(data);//считываем файл
               envelopedCms.Decrypt(); //расшифровываем, для расшифрования ищется сертификат получателя в пользовательском хранилище сертификатов
               var decdoc = envelopedCms.ContentInfo.Content;
                SignedCms signedCms = new SignedCms();
                //расшифровываем Base64
                string b64data = ASCIIEncoding.ASCII.GetString(decdoc);
                var SignedData = GetDataFromBase64(b64data);
                signedCms.Decode(SignedData);//считываем пакет с подписью
                int NumberSign = 0;
                signInfo = new Sign[signedCms.SignerInfos.Count]; //формируем список сертификатов, которые использовались при подписании документа
                foreach (SignerInfo signerInfo in signedCms.SignerInfos) //проверяем все сертификаты
                {
                    // проходим по подписям и проверяем их
                    signInfo[NumberSign] = new Sign(signerInfo); ;
                    signInfo[NumberSign].Result = "Ok";
                    try
                    {
                        signerInfo.CheckSignature(true);
                    }
                    catch (Exception ex)
                    {
                        int ns = NumberSign + 1;
                        signInfo[NumberSign].Result = "Ошибка проверки подписи " + ns + " " + ex.Message;
                    }
                    // и сразу удаляем
                    signedCms.RemoveSignature(signerInfo);
                    NumberSign++;
                }
                dec = signedCms.ContentInfo.Content;
                return true;
            }
            catch (CryptographicException)
            {
                /// ...
                dec = null;
                signInfo = null;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                dec = null;
                signInfo = null;
                return false;
            }
        }
        
        //Можно использовать системное окно или кастомное для выбора сертификата
        public X509Certificate2 GetSert(string caption,string text, string FriendlyName="")
        {
            X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
            X509Certificate2Collection fcollection = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
            X509Certificate2Collection scollection;
            if (FriendlyName=="")
            {
                scollection = X509Certificate2UI.SelectFromCollection(fcollection, caption, text, X509SelectionFlag.MultiSelection,this.Handle );
            }
            else
            {
                scollection = fcollection;
            }
             Console.WriteLine("Number of certificates: {0}{1}", scollection.Count, Environment.NewLine);

            foreach (X509Certificate2 x509 in scollection)
            {
                try
                {
                    byte[] rawdata = x509.RawData;
                    //Console.WriteLine("Content Type: {0}{1}",X509Certificate2.GetCertContentType(rawdata),Environment.NewLine);
                    //Console.WriteLine("Friendly Name: {0}{1}",x509.FriendlyName,Environment.NewLine);
                    //Console.WriteLine("Certificate Verified?: {0}{1}",x509.Verify(),Environment.NewLine);
                    //Console.WriteLine("Simple Name: {0}{1}",x509.GetNameInfo(X509NameType.SimpleName,true),Environment.NewLine);
                    //Console.WriteLine("Signature Algorithm: {0}{1}",x509.SignatureAlgorithm.FriendlyName,Environment.NewLine);
                    //Console.WriteLine("Private Key: {0}{1}",x509.PrivateKey.ToXmlString(false),Environment.NewLine);
                    //Console.WriteLine("Public Key: {0}{1}",x509.PublicKey.Key.ToXmlString(false),Environment.NewLine);
                    //Console.WriteLine("Certificate Archived?: {0}{1}",x509.Archived,Environment.NewLine);
                    //Console.WriteLine("Length of Raw Data: {0}{1}",x509.RawData.Length,Environment.NewLine);
                    if (FriendlyName == "")
                    {
                        return x509;
                    }
                    else
                    {
                        if (x509.FriendlyName == FriendlyName )
                        {
                             return x509;
                        }
                    }
                    //X509Certificate2UI.DisplayCertificate(x509);
                   
                }
                catch (CryptographicException)
                {
                    Console.WriteLine("Information could not be written out for this certificate.");
                }
            }
            store.Close();
            return null;
        }

        private void mButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            WindowsFormsApplication1.Properties.Settings.Default.Save();
        }

        private void mButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            docsFolderBasic.Text  = fb.SelectedPath;
        }

        private void mButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            DocsFolderSigned.Text   = fb.SelectedPath;
        }

        private void mButton4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            DocsFolderChecked.Text   = fb.SelectedPath;
        }

        private void mButton3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(docsFolderBasic.Text))
            {
                MessageBox.Show("Задайте папки для документов");
                return;
            }
            if (!Directory.Exists(DocsFolderChecked.Text  ))
            {
                Directory.CreateDirectory(docsFolderBasic.Text);
            }
            if (!Directory.Exists(DocsFolderSigned.Text ))
            {
                Directory.CreateDirectory(DocsFolderSigned.Text);
            }
            string filesdir = docsFolderBasic.Text   + "\\";
            string signsdir = DocsFolderSigned.Text  + "\\";
            var signsert = GetSert("Сертификат подписи", "Выберите сертификат для подписи документов");
            var encryptsert = GetSert("Сертификат получателя", "Выберите сертификат получателя (который будет использоваться для расшифровки)");
            var filestosign = Directory.GetFiles(docsFolderBasic.Text);
            mButton3.Visible  = false;//отключаем кнопку "подписать"
            signProg.Visible = true; //включаем прогресс бар
            signProg.Maximum = filestosign.Length; //устанавливаем максимальное значение для ProgressBar 
            MethodInvoker ThreadRun = new MethodInvoker(delegate //запускаем процесс в отдельном потоке, чтобы не тормозить форму
                    {
                        int n=0;
                        foreach (var file in filestosign)
                        {
                            byte[] signeddata;
                            var encode = SignAndEncode(File.ReadAllBytes(file), out signeddata,signsert , encryptsert );//подписываем и шифруем документ
                            string filename = Path.GetFileName(file);
                            File.WriteAllBytes(signsdir+filename  + ".crp", encode); //сохраняем зашифрованный подписанный документ
                            File.WriteAllBytes(signsdir+filename  + ".sgn", signeddata); //сохраняем подписанный документ без шифрования (для проверки сервисом КриптоПро)
                            n++;
                            signProg.Invoke(new Action(() => signProg.Value = n)); //обновляем прогресс бар в потоке формы
                        }
                        mButton3.Invoke(new Action(() => mButton3.Visible = true));//включаем кнопку обратно
                        signProg.Invoke(new Action(() => signProg.Visible = false ));
                        MessageBox.Show("Все документы подписаны и зашифрованны.");
                    });
            ThreadRun.BeginInvoke(null, null);//запускаем процесс в отдельном потоке, чтобы не тормозить форму
        }

        private void mButton5_Click(object sender, EventArgs e)
        {
            string checkeddir = DocsFolderChecked.Text + "\\";
            var files = Directory.GetFiles(DocsFolderSigned.Text,"*.crp");
            if (files.Length ==0)
            {
                MessageBox.Show("В папке нет подписанных документов.");
                return;
            }
            checkProg.Maximum = files.Length;
            int n = 0;

            List<Sign> AllSignes = new List<Sign>();
            mButton5.Visible = false;
            MethodInvoker ThreadRun = new MethodInvoker(delegate
            {
                foreach (var file in files)
                {
                    string filename = file.Replace(".crp", "");
                    filename = Path.GetFileName(filename);
                    byte[] encode = File.ReadAllBytes(file); //читаем зашифрованный и подписанный файл
                    byte[] decode;
                    Sign[] signers;
                    if (Decrypt(encode, out decode, out signers, false)) //расшифровываем файл и проверяем подписи
                    {
                        File.WriteAllBytes(checkeddir+filename, decode); //если все ОК сохраняем файл
                    }
                    foreach (var item in signers) //сохраняем результат сканирования в список
                    {
                        item.FileName = filename;
                        AllSignes.Add(item);
                    }
                    n++;
                    checkProg.Invoke(new Action(() => checkProg.Value = n)); //обновляем прогресс бар в потоке формы
                    dataGridView1.Invoke(new Action(() =>//обновляем таблицу с результатами проверки
                    {
                        var source = new BindingSource();
                        source.DataSource = from nn in AllSignes orderby nn.FileName descending select nn;
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DataSource = source;
                        dataGridView1.ReadOnly = true;
                    }));//обновляем таблицу с результатами проверки
                }
                mButton5.Invoke(new Action(() => mButton5.Visible = true));//включаем кнопку обратно
                MessageBox.Show("Все документы проверены и сохранены.");
            });
            ThreadRun.BeginInvoke(null, null);//запускаем процесс в отдельном потоке, чтобы не тормозить форму
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0 )
            {
                var row = (DataGridViewRow)dataGridView1.SelectedRows[0];
                string filename = DocsFolderChecked.Text + "\\"+row.Cells[0].Value  ;
                Process.Start(filename);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = (DataGridViewRow)dataGridView1.SelectedRows[0];
                string filename = DocsFolderChecked.Text + "\\" + row.Cells[0].Value;
                Process.Start(filename);
            }
        }

        private void просмотретьСертификатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = (DataGridViewRow)dataGridView1.SelectedRows[0];
                var sert = ((Sign)row.DataBoundItem).Cert;
                X509Certificate2UI.DisplayCertificate(sert);
            }
        }
    }
}
