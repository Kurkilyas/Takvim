using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti() //Sql bağlantısını buraya kurduk.
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QIOMRSU\\SQLEXPRESS;Initial Catalog=TakvimVeriTabani;Integrated Security=True");
            
            return baglan;
        }
    }
}
