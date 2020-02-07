using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("第"+i+"遍好好学习，天天向上");
            }
            */
            /*
            Console.Write("输入姓名");
            string name = Console.ReadLine();
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("输入第"+i+"门成绩");
                double cj = double.Parse(Console.ReadLine());
                sum += cj;
            }
            Console.WriteLine(name+"的平均成绩是"+(sum/5));
            */
            /*
            Console.WriteLine("输入值");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("根据这个值输出");
            for (int i = 0,j=num; i <= num; i++,j--)
            {
                Console.WriteLine(i+"+"+j+"="+(i+j));
            }
            */
            /*
            Console.Write("输入姓名");
            string name = Console.ReadLine();
            double sum = 0;
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("输入第" + i + "门成绩");
                double cj = double.Parse(Console.ReadLine());
                if (cj < 0)
                {
                    break;
                }
                sum += cj;
            }
            if (i == 6)
                Console.WriteLine(name + "的平均成绩是" + (sum / 5));
            else
                Console.WriteLine("非法输入");
            */
            /*
            Console.WriteLine("MyShopping管理系统>客户信息管理>添加客户信息");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入会员卡号（四位数）");
                int id = int.Parse(Console.ReadLine());
                if (id > 999 & id < 10000)
                {
                    Console.WriteLine("请输入生日：");
                    string bir = Console.ReadLine();

                    Console.WriteLine("请输入积分：");
                    int cent = int.Parse(Console.ReadLine());

                    Console.WriteLine("会员信息");
                    Console.WriteLine("id\t生日\t积分");
                    Console.WriteLine(id + "\t" + bir + "\t" + cent);
                }
                else
                {
                    Console.WriteLine("输入四位数");
                    continue;
                }
                   
            }
                */
            Console.WriteLine("欢迎登录MyShopping系统!");
            int id = 123;
            int pwd = 123;
            bool flag = false;
            for (int i = 2; i >= 0; i--)
            {
                Console.Write("输入账号");
                int _id = int.Parse(Console.ReadLine());
                if (id != _id)
                {
                    Console.WriteLine("账号不存在，还有" + i + "次机会");
                    continue;
                }
                Console.Write("输入密码");
                int _pwd = int.Parse(Console.ReadLine());
                if (pwd != _pwd)
                {
                    Console.WriteLine("密码错误，还有" + i + "次机会");
                    continue;
                }
                flag = true;
                break;
            }
            if (flag)
                Console.WriteLine("登录成功");
            else
                Console.WriteLine("对不起,您3次均输入错误!");
            Console.ReadKey();
        }
    }
}
