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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veteriner_Otomasyonu
{
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string adsoyad;
        private void HastaGiris_Load(object sender, EventArgs e)
        {
            cmb_Tur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Cinsi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;

            label7.Text = adsoyad;
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
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where Durum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into EvcilHayvan (Ad,Tur,Yas,Cinsiyet,Cinsi,SahipAdSoyad) values (@k1,@k2,@k3,@k4,@k5,@k6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", cmb_Tur.Text);
            komut.Parameters.AddWithValue("@k3", txt_Yas.Text);
            komut.Parameters.AddWithValue("@k4", cmb_Cinsiyet.Text);
            komut.Parameters.AddWithValue("@k5", cmb_Cinsi.Text);
            komut.Parameters.AddWithValue("@k6", label7.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarıyla yapılmıştır.");
        }

        private void btn_KayitliHayvanlarim_Click(object sender, EventArgs e)
        {
            KayitliHayvanlar kh = new KayitliHayvanlar();
            kh.ad = label7.Text;
            kh.Show();
        }

        private void btn_Randevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Randevular SET Durum=@1,RandevuAlan=@k1,Sikayet=@k2 where ID=@k3",bgl.baglanti());
            komut.Parameters.AddWithValue("1", 1);
            komut.Parameters.AddWithValue("@k1", label7.Text);
            komut.Parameters.AddWithValue("@k2", richTextBox1.Text);
            komut.Parameters.AddWithValue("@k3", txt_ID.Text);
            komut.ExecuteNonQuery();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_Gecmis_Click(object sender, EventArgs e)
        {
            GecmisRandevular gr = new GecmisRandevular();
            gr.İsim = label7.Text;
            gr.Show();
        }
    }
}
