using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veteriner_Otomasyonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt ka = new Kayıt();
            ka.Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kullanici where (Ad + ' ' + Soyad)=@k1 and Sifre=@k2",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_KullaniciAdi.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string KYetki = dr["Yetki"].ToString();
                if (KYetki == "Kullanici")
                {
                    HastaGiris hg = new HastaGiris();
                    hg.adsoyad = txt_KullaniciAdi.Text;
                    hg.Show();
                    this.Hide();
                }
                if (KYetki == "Personel")
                {
                    PersonelAnasayfa pa = new PersonelAnasayfa();
                    pa.PersonelAd = txt_KullaniciAdi.Text;
                    pa.Show();
                    this.Hide();
                }
                if (KYetki == "Doktor"){
                    DoktorAnaSayfa da = new DoktorAnaSayfa();
                    da.doktor = txt_KullaniciAdi.Text;
                    da.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı veri girdiniz. Bilgilerinizi kontrol edip tekrar deneyin.");
            }
        }
    }
}
