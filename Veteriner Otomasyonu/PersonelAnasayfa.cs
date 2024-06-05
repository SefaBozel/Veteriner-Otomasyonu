using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner_Otomasyonu
{
    public partial class PersonelAnasayfa : Form
    {
        public PersonelAnasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string PersonelAd;
        private void PersonelAnasayfa_Load(object sender, EventArgs e)
        {
            label7.Text = PersonelAd;

            SqlCommand komut1 = new SqlCommand("SELECT Ad + ' ' + soyad FROM Kullanici WHERE Yetki = 'Doktor'", bgl.baglanti());

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where Durum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Randevular where Durum=1", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void btn_Randevu_Click(object sender, EventArgs e)
            {
            string tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string saat = maskedTextBox1.Text;

            SqlCommand komut = new SqlCommand("insert into Randevular (Tarih,Saat,Doktor,Durum) values (@k1,@k2,@k3,0)", bgl.baglanti());
                komut.Parameters.AddWithValue("@k1", tarih);
                komut.Parameters.AddWithValue("@k2", saat);
                komut.Parameters.AddWithValue("@k3", comboBox1.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla açılmıştır.");
        }

        private void btn_Doktor_Click(object sender, EventArgs e)
        {
            DoktorListesi dl = new DoktorListesi();
            dl.Show();
        }

        private void btn_Kullanici_Click(object sender, EventArgs e)
        {
            KullaniciListesi kl = new KullaniciListesi();
            kl.Show();
        }

        private void btn_Hayvan_Click(object sender, EventArgs e)
        {
            HayvanListesi hl = new HayvanListesi();
            hl.Show();
        }
    }
}
