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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsFolderChecked = new System.Windows.Forms.TextBox();
            this.DocsFolderSigned = new System.Windows.Forms.TextBox();
            this.docsFolderBasic = new System.Windows.Forms.TextBox();
            this.mButton3 = new MButton();
            this.mButton5 = new MButton();
            this.mButton6 = new MButton();
            this.checkProg = new MProgress();
            this.mButton4 = new MButton();
            this.signProg = new MProgress();
            this.mButton2 = new MButton();
            this.mButton1 = new MButton();
            this.modernTheme1 = new ModernTheme();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка с исходными документами:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Папка с подписанными документами:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Папка с проверенными документами:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 296);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(507, 131);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // DocsFolderChecked
            // 
            this.DocsFolderChecked.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "DocsFolderChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DocsFolderChecked.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocsFolderChecked.Location = new System.Drawing.Point(12, 220);
            this.DocsFolderChecked.Name = "DocsFolderChecked";
            this.DocsFolderChecked.Size = new System.Drawing.Size(392, 29);
            this.DocsFolderChecked.TabIndex = 9;
            this.DocsFolderChecked.Text = global::WindowsFormsApplication1.Properties.Settings.Default.DocsFolderChecked;
            // 
            // DocsFolderSigned
            // 
            this.DocsFolderSigned.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "DocsFolderSigned", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DocsFolderSigned.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocsFolderSigned.Location = new System.Drawing.Point(12, 128);
            this.DocsFolderSigned.Name = "DocsFolderSigned";
            this.DocsFolderSigned.Size = new System.Drawing.Size(392, 29);
            this.DocsFolderSigned.TabIndex = 4;
            this.DocsFolderSigned.Text = global::WindowsFormsApplication1.Properties.Settings.Default.DocsFolderSigned;
            // 
            // docsFolderBasic
            // 
            this.docsFolderBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "DocsFolderBasic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.docsFolderBasic.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docsFolderBasic.Location = new System.Drawing.Point(12, 67);
            this.docsFolderBasic.Name = "docsFolderBasic";
            this.docsFolderBasic.Size = new System.Drawing.Size(392, 29);
            this.docsFolderBasic.TabIndex = 0;
            this.docsFolderBasic.Text = global::WindowsFormsApplication1.Properties.Settings.Default.DocsFolderBasic;
            // 
            // mButton3
            // 
            this.mButton3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mButton3.ForeColor = System.Drawing.Color.White;
            this.mButton3.Location = new System.Drawing.Point(248, 163);
            this.mButton3.Name = "mButton3";
            this.mButton3.Size = new System.Drawing.Size(271, 29);
            this.mButton3.TabIndex = 7;
            this.mButton3.Text = "Подписать все документы";
            this.mButton3.Click += new System.EventHandler(this.mButton3_Click);
            // 
            // mButton5
            // 
            this.mButton5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mButton5.ForeColor = System.Drawing.Color.White;
            this.mButton5.Location = new System.Drawing.Point(12, 261);
            this.mButton5.Name = "mButton5";
            this.mButton5.Size = new System.Drawing.Size(507, 29);
            this.mButton5.TabIndex = 12;
            this.mButton5.Text = "Проверить подписи и сохранить документы";
            this.mButton5.Click += new System.EventHandler(this.mButton5_Click);
            // 
            // mButton6
            // 
            this.mButton6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mButton6.ForeColor = System.Drawing.Color.White;
            this.mButton6.Location = new System.Drawing.Point(505, 0);
            this.mButton6.Name = "mButton6";
            this.mButton6.Size = new System.Drawing.Size(26, 25);
            this.mButton6.TabIndex = 15;
            this.mButton6.Text = "X";
            this.mButton6.Click += new System.EventHandler(this.mButton6_Click);
            // 
            // checkProg
            // 
            this.checkProg.Location = new System.Drawing.Point(12, 263);
            this.checkProg.Maximum = 100;
            this.checkProg.Name = "checkProg";
            this.checkProg.Size = new System.Drawing.Size(507, 25);
            this.checkProg.TabIndex = 14;
            this.checkProg.Text = "mProgress2";
            this.checkProg.Value = 50;
            // 
            // mButton4
            // 
            this.mButton4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mButton4.ForeColor = System.Drawing.Color.White;
            this.mButton4.Location = new System.Drawing.Point(409, 220);
            this.mButton4.Name = "mButton4";
            this.mButton4.Size = new System.Drawing.Size(110, 29);
            this.mButton4.TabIndex = 11;
            this.mButton4.Text = "Выбрать";
            this.mButton4.Click += new System.EventHandler(this.mButton4_Click);
            // 
            // signProg
            // 
            this.signProg.Location = new System.Drawing.Point(12, 163);
            this.signProg.Maximum = 100;
            this.signProg.Name = "signProg";
            this.signProg.Size = new System.Drawing.Size(507, 29);
            this.signProg.TabIndex = 8;
            this.signProg.Text = "mProgress1";
            this.signProg.Value = 50;
            this.signProg.Visible = false;
            // 
            // mButton2
            // 
            this.mButton2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mButton2.ForeColor = System.Drawing.Color.White;
            this.mButton2.Location = new System.Drawing.Point(409, 128);
            this.mButton2.Name = "mButton2";
            this.mButton2.Size = new System.Drawing.Size(110, 29);
            this.mButton2.TabIndex = 6;
            this.mButton2.Text = "Выбрать";
            this.mButton2.Click += new System.EventHandler(this.mButton2_Click);
            // 
            // mButton1
            // 
            this.mButton1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mButton1.ForeColor = System.Drawing.Color.White;
            this.mButton1.Location = new System.Drawing.Point(409, 67);
            this.mButton1.Name = "mButton1";
            this.mButton1.Size = new System.Drawing.Size(110, 29);
            this.mButton1.TabIndex = 3;
            this.mButton1.Text = "Выбрать";
            this.mButton1.Click += new System.EventHandler(this.mButton1_Click);
            // 
            // modernTheme1
            // 
            this.modernTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modernTheme1.ForeColor = System.Drawing.Color.Lime;
            this.modernTheme1.Location = new System.Drawing.Point(0, 0);
            this.modernTheme1.Name = "modernTheme1";
            this.modernTheme1.Size = new System.Drawing.Size(531, 438);
            this.modernTheme1.TabIndex = 2;
            this.modernTheme1.Text = "ЭЦП шлюз v1.0 1";
            this.modernTheme1.TitleAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modernTheme1.TitleHeight = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 438);
            this.Controls.Add(this.mButton3);
            this.Controls.Add(this.mButton5);
            this.Controls.Add(this.mButton6);
            this.Controls.Add(this.checkProg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mButton4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocsFolderChecked);
            this.Controls.Add(this.signProg);
            this.Controls.Add(this.mButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocsFolderSigned);
            this.Controls.Add(this.mButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docsFolderBasic);
            this.Controls.Add(this.modernTheme1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docsFolderBasic;
        private System.Windows.Forms.Label label1;
        private ModernTheme modernTheme1;
        private MButton mButton1;
        private MButton mButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocsFolderSigned;
        private MButton mButton3;
        private MProgress signProg;
        private MButton mButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocsFolderChecked;
        private MButton mButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MProgress checkProg;
        private MButton mButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСертификатToolStripMenuItem;
    }
}

