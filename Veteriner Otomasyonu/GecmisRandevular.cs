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
    public partial class GecmisRandevular : Form
    {
        public GecmisRandevular()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string İsim;
        private void GecmisRandevular_Load(object sender, EventArgs e)
        {
            textBox1.Text = İsim;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where RandevuAlan=@k1",bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@k1", textBox1.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
