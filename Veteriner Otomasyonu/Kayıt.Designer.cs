namespace Veteriner_Otomasyonu
{
    partial class Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.txt_TC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(146, 59);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(170, 30);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(146, 116);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(170, 30);
            this.txt_Soyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "T.C. No:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(146, 236);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(170, 30);
            this.txt_Sifre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre:";
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Location = new System.Drawing.Point(102, 305);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(192, 59);
            this.btn_Kayit.TabIndex = 8;
            this.btn_Kayit.Text = "Kayıt Ol";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(146, 176);
            this.txt_TC.Mask = "00000000000";
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(170, 30);
            this.txt_TC.TabIndex = 9;
            this.txt_TC.ValidatingType = typeof(int);
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.MaskedTextBox txt_TC;
    }
}