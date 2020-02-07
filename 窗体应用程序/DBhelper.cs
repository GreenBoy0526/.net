using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 窗体应用程序
{
    class DBhelper
    {
        string str = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection getConn()
        {
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }
    }
}
