using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_类和对象
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            School xuexiao1 = new School();
            xuexiao1.name = "学校1";
            xuexiao1.class_num = 1;
            xuexiao1.lab_num = 2;
            xuexiao1.Show();
            School xuexiao2 = new School();
            xuexiao2.name = "学校1";
            xuexiao2.class_num = 10;
            xuexiao2.lab_num = 23;
            xuexiao2.Show();
            */
            /*
            Teacher te = new Teacher();
            Console.Write("请输入姓名：");
            te.name = Console.ReadLine();
            Console.Write("请输入专业方向：");
            te.pro = Console.ReadLine();
            Console.Write("请输入教授课程：");
            te.obj = Console.ReadLine();
            Console.Write("请输入教龄：");
            te.teach_age = int.Parse(Console.ReadLine()) ;
            te.Show();
            Student st = new Student();
            Console.Write("请输入姓名：");
            st.name = Console.ReadLine();
            Console.Write("请输入年龄：");
            st.age = int.Parse(Console.ReadLine());
            Console.Write("请输入班级：");
            st._class = int.Parse(Console.ReadLine());
            Console.Write("请输入爱好：");
            st.hobby = Console.ReadLine();
            st.Show();
            */
            /*
            while (true)
            {
                youren yr = new youren();
                Console.Write("请输入姓名：");
                yr.name = Console.ReadLine();
                if (yr.name=="n")
                {
                    break;
                }
                yr.Show();
            }
            */
            /*
            Customer cus = new Customer();
            Console.Write("请输入积分：");
            cus.cent = int.Parse(Console.ReadLine());
            Console.Write("请输入卡类型：");
            cus.cardType = Console.ReadLine();
            cus.Show();
            */
            
            Administrator ad1 = new Administrator();
            Console.Write("请输入用户名：");
            ad1.id = Console.ReadLine();
            Console.Write("请输入密码：");
            ad1.pwd = Console.ReadLine();
            Administrator ad2 = new Administrator();
            Console.Write("请输入用户名：");
            ad2.id = Console.ReadLine();
            Console.Write("请输入密码：");
            ad2.pwd = Console.ReadLine();
            ad1.Show();
            ad2.Show();
            ad1.xiuGaiMiMa();
            Console.ReadKey();
        }
    }
}
