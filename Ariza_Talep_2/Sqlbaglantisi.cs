using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariza_Talep_2
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog = Ariza_Talep_2 ; Integrated Security=SSPI");

            //SqlConnection con = new SqlConnection("Data Source = ip; Network Library = DBMSSOCN; Initial Catalog = Ariza_Talep_2; User ID = user; Password = sifre;");
            con.Open();
            return con;
        }
    }
}
