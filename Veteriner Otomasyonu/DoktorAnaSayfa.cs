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
    public partial class DoktorAnaSayfa : Form
    {
        public DoktorAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string doktor;
        private void DoktorAnaSayfa_Load(object sender, EventArgs e)
        {
            label7.Text = doktor;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where Doktor=@k1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@k1", label7.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
