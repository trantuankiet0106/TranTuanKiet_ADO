using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    public class DBConnection
        {
            public DBConnection()
            {
            }
            public SqlConnection CreateConnection()
            {
                SqlConnection conn = new SqlConnection(@"Data Source =TRAN-TUAN-KIET\SQLEXPRESS; Initial Catalog=sale;
                       User id = sa; Password = sa");
                return conn;

            }
        }
   
}
