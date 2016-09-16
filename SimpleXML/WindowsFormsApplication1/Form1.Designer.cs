using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.Button1 = new Ambiance.Ambiance_Button_2();
            this.Button7 = new Ambiance.Ambiance_Button_2();
            this.Button6 = new Ambiance.Ambiance_Button_2();
            this.Button3 = new Ambiance.Ambiance_Button_2();
            this.docsFolderBasic = new Ambiance.Ambiance_TextBox();
            this.Button5 = new Ambiance.Ambiance_Button_2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkProg = new Ambiance.Ambiance_ProgressBar();
            this.label2 = new Ambiance.Ambiance_Label();
            this.Button4 = new Ambiance.Ambiance_Button_2();
            this.label1 = new Ambiance.Ambiance_Label();
            this.label3 = new Ambiance.Ambiance_Label();
            this.DocsFolderSigned = new Ambiance.Ambiance_TextBox();
            this.DocsFolderChecked = new Ambiance.Ambiance_TextBox();
            this.Button2 = new Ambiance.Ambiance_Button_2();
            this.signProg = new Ambiance.Ambiance_ProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.ambiance_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.просмотретьСертификатToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // просмотретьСертификатToolStripMenuItem
            // 
            this.просмотретьСертификатToolStripMenuItem.Name = "просмотретьСертификатToolStripMenuItem";
            this.просмотретьСертификатToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.просмотретьСертификатToolStripMenuItem.Text = "Просмотреть сертификат";
            this.просмотретьСертификатToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСертификатToolStripMenuItem_Click);
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.Button1);
            this.ambiance_ThemeContainer1.Controls.Add(this.Button7);
            this.ambiance_ThemeContainer1.Controls.Add(this.Button6);
            this.ambiance_ThemeContainer1.Controls.Add(this.Button3);
            this.ambiance_ThemeContainer1.Controls.Add(this.docsFolderBasic);
            this.ambiance_ThemeContainer1.Controls.Add(this.Button5);
            this.ambiance_ThemeContainer1.Controls.Add(this.dataGridView1);
            this.ambiance_ThemeContainer1.Controls.Add(this.checkProg);
            this.ambiance_ThemeContainer1.Controls.Add(this.label2);
            this.ambiance_ThemeContainer1.Controls.Add(this.Button4);
            this.ambiance_ThemeContainer1.Controls.Add(this.label1);
            this.ambiance_ThemeContainer1.Controls.Add(this.label3);
            this.ambiance_ThemeContainer1.Controls.Add(this.DocsFolderSigned);
            this.ambiance_ThemeContainer1.Controls.Add(this.DocsFolderChecked);
            this.ambiance_ThemeContainer1.Controls.Add(this.Button2);
            this.ambiance_ThemeContainer1.Controls.Add(this.signProg);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = true;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(552, 507);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambiance_ThemeContainer1.TabIndex = 17;
            this.ambiance_ThemeContainer1.Text = "ЭЦП шлюз v1.2";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Image = null;
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(413, 75);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(123, 32);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "Выбрать папку";
            this.Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button1.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Transparent;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button7.Image = null;
            this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button7.Location = new System.Drawing.Point(15, 169);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(213, 29);
            this.Button7.TabIndex = 16;
            this.Button7.Text = "Создать новый ключ RSA";
            this.Button7.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Transparent;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button6.Image = null;
            this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button6.Location = new System.Drawing.Point(514, 12);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(26, 25);
            this.Button6.TabIndex = 15;
            this.Button6.Text = "X";
            this.Button6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Transparent;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button3.Image = null;
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(265, 169);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(271, 29);
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Подписать все документы";
            this.Button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // docsFolderBasic
            // 
            this.docsFolderBasic.BackColor = System.Drawing.Color.Transparent;
            this.docsFolderBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "DocsFolderBasic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.docsFolderBasic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docsFolderBasic.ForeColor = System.Drawing.Color.DimGray;
            this.docsFolderBasic.Location = new System.Drawing.Point(15, 75);
            this.docsFolderBasic.MaxLength = 32767;
            this.docsFolderBasic.Multiline = false;
            this.docsFolderBasic.Name = "docsFolderBasic";
            this.docsFolderBasic.ReadOnly = false;
            this.docsFolderBasic.Size = new System.Drawing.Size(392, 28);
            this.docsFolderBasic.TabIndex = 0;
            this.docsFolderBasic.Text = global::WindowsFormsApplication1.Properties.Settings.Default.DocsFolderBasic;
            this.docsFolderBasic.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.docsFolderBasic.UseSystemPasswordChar = false;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Transparent;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button5.Image = null;
            this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button5.Location = new System.Drawing.Point(16, 285);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(520, 29);
            this.Button5.TabIndex = 12;
            this.Button5.Text = "Проверить подписи и сохранить документы";
            this.Button5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 346);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 149);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // checkProg
            // 
            this.checkProg.BackColor = System.Drawing.Color.Transparent;
            this.checkProg.DrawHatch = true;
            this.checkProg.Location = new System.Drawing.Point(15, 320);
            this.checkProg.Maximum = 100;
            this.checkProg.Minimum = 0;
            this.checkProg.MinimumSize = new System.Drawing.Size(58, 20);
            this.checkProg.Name = "checkProg";
            this.checkProg.ShowPercentage = false;
            this.checkProg.Size = new System.Drawing.Size(521, 20);
            this.checkProg.TabIndex = 14;
            this.checkProg.Text = "Ambiance.Ambiance_ProgressBar2";
            this.checkProg.Value = 0;
            this.checkProg.ValueAlignment = Ambiance.Ambiance_ProgressBar.Alignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Папка с подписанными документами:";
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Transparent;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button4.Image = null;
            this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button4.Location = new System.Drawing.Point(413, 250);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(123, 32);
            this.Button4.TabIndex = 11;
            this.Button4.Text = "Выбрать папку";
            this.Button4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка с исходными документами:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Папка с проверенными документами:";
            // 
            // DocsFolderSigned
            // 
            this.DocsFolderSigned.BackColor = System.Drawing.Color.Transparent;
            this.DocsFolderSigned.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "DocsFolderSigned", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DocsFolderSigned.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocsFolderSigned.ForeColor = System.Drawing.Color.DimGray;
            this.DocsFolderSigned.Location = new System.Drawing.Point(15, 131);
            this.DocsFolderSigned.MaxLength = 32767;
            this.DocsFolderSigned.Multiline = false;
            this.DocsFolderSigned.Name = "DocsFolderSigned";
            this.DocsFolderSigned.ReadOnly = false;
            this.DocsFolderSigned.Size = new System.Drawing.Size(392, 28);
            this.DocsFolderSigned.TabIndex = 4;
            this.DocsFolderSigned.Text = global::WindowsFormsApplication1.Properties.Settings.Default.DocsFolderSigned;
            this.DocsFolderSigned.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocsFolderSigned.UseSystemPasswordChar = false;
            // 
            // DocsFolderChecked
            // 
            this.DocsFolderChecked.BackColor = System.Drawing.Color.Transparent;
            this.DocsFolderChecked.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "DocsFolderChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DocsFolderChecked.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocsFolderChecked.ForeColor = System.Drawing.Color.DimGray;
            this.DocsFolderChecked.Location = new System.Drawing.Point(15, 250);
            this.DocsFolderChecked.MaxLength = 32767;
            this.DocsFolderChecked.Multiline = false;
            this.DocsFolderChecked.Name = "DocsFolderChecked";
            this.DocsFolderChecked.ReadOnly = false;
            this.DocsFolderChecked.Size = new System.Drawing.Size(392, 28);
            this.DocsFolderChecked.TabIndex = 9;
            this.DocsFolderChecked.Text = global::WindowsFormsApplication1.Properties.Settings.Default.DocsFolderChecked;
            this.DocsFolderChecked.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocsFolderChecked.UseSystemPasswordChar = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Image = null;
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(413, 131);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(123, 32);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Выбрать папку";
            this.Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // signProg
            // 
            this.signProg.BackColor = System.Drawing.Color.Transparent;
            this.signProg.DrawHatch = true;
            this.signProg.Location = new System.Drawing.Point(15, 204);
            this.signProg.Maximum = 100;
            this.signProg.Minimum = 0;
            this.signProg.MinimumSize = new System.Drawing.Size(58, 20);
            this.signProg.Name = "signProg";
            this.signProg.ShowPercentage = false;
            this.signProg.Size = new System.Drawing.Size(521, 20);
            this.signProg.TabIndex = 8;
            this.signProg.Text = "Ambiance.Ambiance_ProgressBar1";
            this.signProg.Value = 0;
            this.signProg.ValueAlignment = Ambiance.Ambiance_ProgressBar.Alignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 507);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Form1";
            this.Text = "ЭЦП шлюз v1.2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.ambiance_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_TextBox  docsFolderBasic;
        private Ambiance.Ambiance_Label label1;
        private Ambiance.Ambiance_Button_2 Button2;
        private Ambiance.Ambiance_Label label2;
        private Ambiance.Ambiance_TextBox DocsFolderSigned;
        private Ambiance.Ambiance_Button_2 Button3;
        private Ambiance.Ambiance_ProgressBar signProg;
        private Ambiance.Ambiance_Button_2 Button4;
        private Ambiance.Ambiance_Label label3;
        private Ambiance.Ambiance_TextBox DocsFolderChecked;
        private Ambiance.Ambiance_Button_2 Button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Ambiance.Ambiance_ProgressBar checkProg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСертификатToolStripMenuItem;
        private Ambiance.Ambiance_Button_2 Button7;
        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private Ambiance.Ambiance_Button_2 Button1;
        private Ambiance.Ambiance_Button_2 Button6;
    }
}

