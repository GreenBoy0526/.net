using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySchoolBase
{
    class School
    {
        SqlConnection conn = null;
        //登录
        public void Login()
        {

            try
            {
                string str = "Data Source=.;Initial Catalog=MyStudent;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn = new SqlConnection(str);
                Console.WriteLine("登录成功");
                menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常退出");
            }
        }
        //菜单
        public void menu()
        {
            conn.Close();
            conn.Open();
            Console.WriteLine("===请选择操作===");
            Console.WriteLine("1、查询学生数量");
            Console.WriteLine("2、查看学生用户列表");
            Console.WriteLine("3、查询指定学生姓名");
            Console.WriteLine("4、查询制定学生的所有基本信息");
            Console.WriteLine("5、插入年级信息");
            Console.WriteLine("6、修改学生生日信息");
            Console.WriteLine("7、删除学生信息");
            Console.WriteLine("8、退出");
            Console.WriteLine("================");
            string xuanze = Console.ReadLine();
            switch (xuanze)
            {
                case "1":
                    Count();
                    break;
                case "2":
                    chaKan();
                    break;
                case "3":
                    xingMing();
                    break;
                case "4":
                    jiBenXinXi();
                    break;
                case "5":
                    chaRuNianJi();
                    break;
                case "6":
                    updateBirth();
                    break;
                case "7":
                    Delete();
                    break;
                case "8":
                    break;
                default:
                    Console.WriteLine("请重新选择");
                    break;
            }
            if (xuanze!="8")
            {
                menu();
            }
            
        }
        //查询数量
        public void Count()
        {
            string sql = "select count(*) from Student";
            SqlCommand comm = new SqlCommand(sql, conn);
            Console.WriteLine(comm.ExecuteScalar());
        }
        //查看信息
        public void chaKan()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select");
            sql.Append("    Studentno,");
            sql.Append("    StudentName ");
            sql.Append("from");
            sql.Append("    Student");
            sql.Append("");

            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine(read["Studentno"] + "\t" + read["StudentName"]);
            }
        }
        // 查看姓名
        public void xingMing()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");
            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine();
            }
        }
        //基本信息
        public void jiBenXinXi()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");
            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine();
            }
        }
        //插入年级
        public void chaRuNianJi()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");
            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine();
            }
        }
        //修改生日
        public void updateBirth()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");
            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine();
            }
        }
        //删除
        public void Delete()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");
            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine();
            }
        }
    }
}