using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Veteriner_Otomasyonu
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S59HMG2\\MSSQLSERVER03;Initial Catalog=Veteriner_Otomasyonu;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
        
    }
}
