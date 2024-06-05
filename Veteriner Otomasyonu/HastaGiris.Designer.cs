namespace Veteriner_Otomasyonu
{
    partial class HastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_KayitliHayvanlarim = new System.Windows.Forms.Button();
            this.cmb_Cinsi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.cmb_Tur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Randevu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_İptal = new System.Windows.Forms.Button();
            this.btn_Gecmis = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_KayitliHayvanlarim);
            this.groupBox1.Controls.Add(this.cmb_Cinsi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Yas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_Cinsiyet);
            this.groupBox1.Controls.Add(this.cmb_Tur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Controls.Add(this.btn_Kaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evcil Hayvan Kayıtlama";
            // 
            // btn_KayitliHayvanlarim
            // 
            this.btn_KayitliHayvanlarim.Location = new System.Drawing.Point(26, 396);
            this.btn_KayitliHayvanlarim.Name = "btn_KayitliHayvanlarim";
            this.btn_KayitliHayvanlarim.Size = new System.Drawing.Size(177, 58);
            this.btn_KayitliHayvanlarim.TabIndex = 6;
            this.btn_KayitliHayvanlarim.Text = "Evcil Hayvanlarım";
            this.btn_KayitliHayvanlarim.UseVisualStyleBackColor = true;
            this.btn_KayitliHayvanlarim.Click += new System.EventHandler(this.btn_KayitliHayvanlarim_Click);
            // 
            // cmb_Cinsi
            // 
            this.cmb_Cinsi.FormattingEnabled = true;
            this.cmb_Cinsi.Location = new System.Drawing.Point(104, 82);
            this.cmb_Cinsi.Name = "cmb_Cinsi";
            this.cmb_Cinsi.Size = new System.Drawing.Size(121, 33);
            this.cmb_Cinsi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cinsi:";
            // 
            // txt_Yas
            // 
            this.txt_Yas.Location = new System.Drawing.Point(104, 212);
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.Size = new System.Drawing.Size(121, 30);
            this.txt_Yas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yaşı:";
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(104, 281);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(121, 33);
            this.cmb_Cinsiyet.TabIndex = 4;
            // 
            // cmb_Tur
            // 
            this.cmb_Tur.FormattingEnabled = true;
            this.cmb_Tur.Location = new System.Drawing.Point(104, 26);
            this.cmb_Tur.Name = "cmb_Tur";
            this.cmb_Tur.Size = new System.Drawing.Size(121, 33);
            this.cmb_Tur.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cinsiyeti:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(104, 145);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(121, 30);
            this.txt_Ad.TabIndex = 2;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(26, 332);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(177, 58);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.btn_Randevu);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Al";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(531, 270);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 30);
            this.txt_ID.TabIndex = 9;
            this.txt_ID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şikayet";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 295);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(319, 148);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // btn_Randevu
            // 
            this.btn_Randevu.Location = new System.Drawing.Point(361, 317);
            this.btn_Randevu.Name = "btn_Randevu";
            this.btn_Randevu.Size = new System.Drawing.Size(238, 82);
            this.btn_Randevu.TabIndex = 8;
            this.btn_Randevu.Text = "Randevu Al";
            this.btn_Randevu.UseVisualStyleBackColor = true;
            this.btn_Randevu.Click += new System.EventHandler(this.btn_Randevu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_İptal);
            this.groupBox3.Controls.Add(this.btn_Gecmis);
            this.groupBox3.Location = new System.Drawing.Point(261, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı İşlemler";
            // 
            // btn_İptal
            // 
            this.btn_İptal.Location = new System.Drawing.Point(352, 53);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(170, 63);
            this.btn_İptal.TabIndex = 10;
            this.btn_İptal.Text = "Randevu İptal";
            this.btn_İptal.UseVisualStyleBackColor = true;
            // 
            // btn_Gecmis
            // 
            this.btn_Gecmis.Location = new System.Drawing.Point(69, 53);
            this.btn_Gecmis.Name = "btn_Gecmis";
            this.btn_Gecmis.Size = new System.Drawing.Size(170, 63);
            this.btn_Gecmis.TabIndex = 9;
            this.btn_Gecmis.Text = "Geçmiş Randevularım";
            this.btn_Gecmis.UseVisualStyleBackColor = true;
            this.btn_Gecmis.Click += new System.EventHandler(this.btn_Gecmis_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 106);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgiler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ad Soyad:";
            // 
            // HastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "HastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.HastaGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Yas;
        private System.Windows.Forms.ComboBox cmb_Tur;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.Button btn_KayitliHayvanlarim;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Randevu;
        private System.Windows.Forms.Button btn_İptal;
        private System.Windows.Forms.Button btn_Gecmis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmb_Cinsi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ID;
    }
}