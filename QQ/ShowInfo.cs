using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ
{
    class ShowInfo
    {
        public void showInfo(SqlConnection conn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select ");
            sql.Append("    BaseInfo.QQID, ");
            sql.Append("    NickName ,");
            sql.Append("    level ,");
            sql.Append("    Online ");
            sql.Append("from BaseInfo ");
            sql.Append("inner join QQUser ");
            sql.Append("     on QQUser.QQID=BaseInfo.QQID");
            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            Console.WriteLine("QQ号\t昵称\t等级\t在线天数");
            while (read.Read())
            {
                Console.WriteLine(read["QQID"] + "\t" + read["NickName"] + "\t" + showLevel(read["level"]) + "\t" + read["Online"]);
            }
        }

        private string showLevel(object v)
        {
            string lev = v.ToString();
            if (int.Parse(lev) < 1)
            {
                lev = "-";
            }
            else if (int.Parse(lev) < 4)
            {
                lev = "*";
            }
            else if (int.Parse(lev) < 10)
            {
                lev = "€";
            }
            else
            {
                lev = "⚪";
            }
            return lev;
        }
    }
}
