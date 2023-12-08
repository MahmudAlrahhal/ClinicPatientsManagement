using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DbConnection
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8S8D5IM\\MSSQLSERVER01; Initial Catalog=MustafaClinic; Integrated Security=True;");
    }
}
