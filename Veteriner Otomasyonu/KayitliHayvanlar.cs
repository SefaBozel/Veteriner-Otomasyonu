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
    public partial class KayitliHayvanlar : Form
    {
        public KayitliHayvanlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string ad;
        private void KayitliHayvanlar_Load(object sender, EventArgs e)
        {
            label1.Text = ad;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from EvcilHayvan where SahipAdSoyad='" + ad + "'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
