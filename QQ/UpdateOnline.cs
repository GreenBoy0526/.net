using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ
{
    class UpdateOnline
    {
      public void update(SqlConnection conn)
        {
            Console.WriteLine("请输入更新的QQ");
            string qq = Console.ReadLine();
            Console.WriteLine("请输入新的在线天数");
            string day = Console.ReadLine();
            string sql = "update QQUser set online="+day+" where QQID="+qq;
            SqlCommand comm = new SqlCommand(sql, conn);
            Console.WriteLine("修改成功");
        }
    }
}
