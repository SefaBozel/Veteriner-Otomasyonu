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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanici (Ad,Soyad,TCNo,Sifre) values (@k1,@k2,@k3,@k4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3", txt_TC.Text);
            komut.Parameters.AddWithValue("@k4", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız başarıyla gerçekleşti.\n Kullanıcı Adınız:" + txt_Ad.Text + " " + txt_Soyad.Text + "\n Şifreniz: " + txt_Sifre.Text);
        }
    }
}
