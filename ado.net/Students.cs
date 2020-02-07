using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net
{
    class Students
    {
        public void Login(string name, string password)
        {
            SqlConnection conn=null;
            try
            {
                string str = "Data Source=.;Initial Catalog=MyStudent;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn = new SqlConnection(str);
                conn.Open();

                string denglu = "select count(*) from Student where StudentName='" + name + "'and LoginPwd='" + password+"'";
                SqlCommand comm = new SqlCommand(denglu,conn);
                int i = (int)comm.ExecuteScalar();
                if (i == 1)
                    Console.WriteLine("登录成功");
                else
                    Console.WriteLine("登录失败");
            }
            catch (Exception ex)
            {
                Console.WriteLine("链接失败");
            }
            finally
            {
                conn.Close();
                Console.WriteLine("成功关闭");
            }
        }
    }
}
