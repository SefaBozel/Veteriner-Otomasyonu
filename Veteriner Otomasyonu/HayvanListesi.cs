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
    public partial class HayvanListesi : Form
    {
        public HayvanListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void HayvanListesi_Load(object sender, EventArgs e)
        {
            cmb_Cinsiyet.Items.Add("Dişi");
            cmb_Cinsiyet.Items.Add("Erkek");
            cmb_Tur.Items.Add("Kuş");
            cmb_Tur.Items.Add("Köpek");
            cmb_Tur.Items.Add("Kedi");
            cmb_Tur.Items.Add("Balık");
            cmb_Cinsi.Items.Add("Muhabbet");
            cmb_Cinsi.Items.Add("Papağan");
            cmb_Cinsi.Items.Add("Güvercin");
            cmb_Cinsi.Items.Add("Labrador Retriever");
            cmb_Cinsi.Items.Add("Alman Çoban Köpeği");
            cmb_Cinsi.Items.Add("Golden Retriever");
            cmb_Cinsi.Items.Add("Pitbull");
            cmb_Cinsi.Items.Add("Sibirya Huskisi");
            cmb_Cinsi.Items.Add("Chihuahua");
            cmb_Cinsi.Items.Add("Bulldog");
            cmb_Cinsi.Items.Add("Van Kedisi");
            cmb_Cinsi.Items.Add("Sokak Kedisi");
            cmb_Cinsi.Items.Add("Tekir");
            cmb_Cinsi.Items.Add("British Shorthair");
            cmb_Cinsi.Items.Add("Scottish Fold");
            cmb_Cinsi.Items.Add("Pers Kedisi");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Evcilhayvan",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Evcilhayvan (Ad,Tur,Yas,Cinsiyet,Cinsi,SahipAdSoyad) values (@k1,@k2,@k3,@k4,@k5,@k6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", cmb_Tur.Text);
            komut.Parameters.AddWithValue("@k3", txt_Yas.Text);
            komut.Parameters.AddWithValue("@k4", cmb_Cinsiyet.Text);
            komut.Parameters.AddWithValue("@k5", cmb_Cinsi.Text);
            komut.Parameters.AddWithValue("@k6", txt_Sahip.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla eklenmiştir.");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Evcilhayvan SET Ad=@k1,Tur=@k2,Yas=@k3,Cinsiyet=@k4,Cinsi=@k5,SahipAdSoyad=@k6 where ID=@k7",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", cmb_Tur.Text);
            komut.Parameters.AddWithValue("@k3", txt_Yas.Text);
            komut.Parameters.AddWithValue("@k4", cmb_Cinsiyet.Text);
            komut.Parameters.AddWithValue("@k5", cmb_Cinsi.Text);
            komut.Parameters.AddWithValue("@k6", txt_Sahip.Text);
            komut.Parameters.AddWithValue("@k7", txt_ID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellenmiştir.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmb_Tur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Yas.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmb_Cinsiyet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmb_Cinsi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_Sahip.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Evcilhayvan where ID=@k7", bgl.baglanti());
            komut.Parameters.AddWithValue("@k7", txt_ID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla silinmiştir.");
        }
    }
}
