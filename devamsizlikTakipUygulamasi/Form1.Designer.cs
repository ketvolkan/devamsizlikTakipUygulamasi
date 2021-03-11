namespace devamsizlikTakipUygulamasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxDersler = new System.Windows.Forms.GroupBox();
            this.lbldersad = new System.Windows.Forms.Label();
            this.cbxhaftalar = new System.Windows.Forms.ComboBox();
            this.gbxislem = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxdurum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcanli = new System.Windows.Forms.Label();
            this.lbltekrar = new System.Windows.Forms.Label();
            this.lblizlenmeyen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxislem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDersler
            // 
            this.gbxDersler.Location = new System.Drawing.Point(22, 12);
            this.gbxDersler.Name = "gbxDersler";
            this.gbxDersler.Size = new System.Drawing.Size(298, 518);
            this.gbxDersler.TabIndex = 0;
            this.gbxDersler.TabStop = false;
            this.gbxDersler.Text = "Dersler";
            // 
            // lbldersad
            // 
            this.lbldersad.AutoSize = true;
            this.lbldersad.Location = new System.Drawing.Point(24, 25);
            this.lbldersad.Name = "lbldersad";
            this.lbldersad.Size = new System.Drawing.Size(53, 13);
            this.lbldersad.TabIndex = 0;
            this.lbldersad.Text = "[Ders Adı]";
            // 
            // cbxhaftalar
            // 
            this.cbxhaftalar.FormattingEnabled = true;
            this.cbxhaftalar.Location = new System.Drawing.Point(62, 39);
            this.cbxhaftalar.Name = "cbxhaftalar";
            this.cbxhaftalar.Size = new System.Drawing.Size(176, 21);
            this.cbxhaftalar.TabIndex = 1;
            // 
            // gbxislem
            // 
            this.gbxislem.Controls.Add(this.groupBox3);
            this.gbxislem.Controls.Add(this.groupBox2);
            this.gbxislem.Controls.Add(this.groupBox1);
            this.gbxislem.Controls.Add(this.lbldersad);
            this.gbxislem.Location = new System.Drawing.Point(341, 12);
            this.gbxislem.Name = "gbxislem";
            this.gbxislem.Size = new System.Drawing.Size(724, 518);
            this.gbxislem.TabIndex = 2;
            this.gbxislem.TabStop = false;
            this.gbxislem.Text = "İşlem Ekranı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(62, 91);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(176, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Durumu Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hafta";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durum";
            // 
            // cbxdurum
            // 
            this.cbxdurum.FormattingEnabled = true;
            this.cbxdurum.Location = new System.Drawing.Point(62, 64);
            this.cbxdurum.Name = "cbxdurum";
            this.cbxdurum.Size = new System.Drawing.Size(176, 21);
            this.cbxdurum.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxhaftalar);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cbxdurum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devam Bilgisi Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(27, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 277);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devamlılık Tablo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblizlenmeyen);
            this.groupBox3.Controls.Add(this.lbltekrar);
            this.groupBox3.Controls.Add(this.lblcanli);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(423, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 142);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devam Bilgisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Hafta : 15";
            // 
            // lblcanli
            // 
            this.lblcanli.AutoSize = true;
            this.lblcanli.Location = new System.Drawing.Point(18, 64);
            this.lblcanli.Name = "lblcanli";
            this.lblcanli.Size = new System.Drawing.Size(82, 13);
            this.lblcanli.TabIndex = 7;
            this.lblcanli.Text = "Canlı İzlenen : 0";
            // 
            // lbltekrar
            // 
            this.lbltekrar.AutoSize = true;
            this.lbltekrar.Location = new System.Drawing.Point(8, 81);
            this.lbltekrar.Name = "lbltekrar";
            this.lbltekrar.Size = new System.Drawing.Size(92, 13);
            this.lbltekrar.TabIndex = 8;
            this.lbltekrar.Text = "Tekrarı İzlenen : 0";
            // 
            // lblizlenmeyen
            // 
            this.lblizlenmeyen.AutoSize = true;
            this.lblizlenmeyen.Location = new System.Drawing.Point(25, 96);
            this.lblizlenmeyen.Name = "lblizlenmeyen";
            this.lblizlenmeyen.Size = new System.Drawing.Size(75, 13);
            this.lblizlenmeyen.TabIndex = 9;
            this.lblizlenmeyen.Text = "İzlenmeyen : 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1043, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ders Ekle/Çıkar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxislem);
            this.Controls.Add(this.gbxDersler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Devamsızlık Takip Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxislem.ResumeLayout(false);
            this.gbxislem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDersler;
        private System.Windows.Forms.Label lbldersad;
        private System.Windows.Forms.ComboBox cbxhaftalar;
        private System.Windows.Forms.GroupBox gbxislem;
        private System.Windows.Forms.ComboBox cbxdurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblizlenmeyen;
        private System.Windows.Forms.Label lbltekrar;
        private System.Windows.Forms.Label lblcanli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

