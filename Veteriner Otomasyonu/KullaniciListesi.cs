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
    public partial class KullaniciListesi : Form
    {
        public KullaniciListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanici (Ad,Soyad,TCNo,Sifre,Yetki) values (@k1,@k2,@k3,@k4,'Kullanici')",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3", txt_TC.Text);
            komut.Parameters.AddWithValue("@k4", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla eklenmiştir.");
        }

        private void KullaniciListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kullanici where Yetki='Kullanici'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_TC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Kullanici set Ad=@k1,Soyad=@k2,Sifre=@k3 where TCNo=@k4", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@k4", txt_TC.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellenmiştir.");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Kullanici where TCNo=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_TC.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla silinmiştir.");
        }
    }
}
