using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaatZ
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=WINDOWS-C8FJ4V7;Initial Catalog=DboInsaatZ;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
