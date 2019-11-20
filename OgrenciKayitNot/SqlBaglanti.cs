using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrenciKayitNot
{
    class SqlBaglanti
    {
        public SqlConnection bagglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=ogrenciNotKayitSistemiDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
