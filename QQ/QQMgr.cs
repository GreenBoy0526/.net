using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QQ
{
    class QQMgr
    {
        SqlConnection conn;
        public void Login()
        {
            try
            {
                string str = "Data Source=.;Initial Catalog=QQ;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn = new SqlConnection(str);
                Console.WriteLine("登录成功！");
                Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常退出");
                Console.WriteLine(ex.ToString());
            }
        }
        public void Menu()
        {
            conn.Close();
            conn.Open();
            Console.WriteLine("====欢迎使用QQ用户信息管理系统====");
            Console.WriteLine("-------请选择操作键-------");
            Console.WriteLine("1.显示用户信息");
            Console.WriteLine("2.更新在线天数");
            Console.WriteLine("3.添加用户");
            Console.WriteLine("4.更新用户等级");
            Console.WriteLine("5.删除用户");
            Console.WriteLine("6.退出");
            Console.WriteLine("======================");

            string xuanze = Console.ReadLine();
            switch (xuanze)
            {
                case "1":
                    ShowInfo info = new ShowInfo();
                    info.showInfo(conn);
                    break;
                case "2":
                    UpdateOnline up = new UpdateOnline();
                    up.update(conn);
                    break;
                case "3":
                    
                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":
                    Console.WriteLine("再见");
                    break;
                default:
                    Console.WriteLine("非法输入");
                    break;
            }
            if (xuanze!="6")
            {
                Menu();
            }
        }
        

        
    }
}
