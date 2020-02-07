using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一章
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=========== 购物清单 =========== ");
            Console.WriteLine("商品名称\t购买数量\t商品单价\t金额");
            Console.WriteLine("鳄鱼夹克\t1\t\t￥1900\t\t￥1900");
            Console.WriteLine("mp4\t\t2\t\t￥400\t\t￥800");

            Console.WriteLine("\n");

            Console.WriteLine("\t\t欢迎使用我行我素购物管理系统1.0版\n");
            Console.WriteLine("\t\t\t\t1.登录系统\n");
            Console.WriteLine("\t\t\t\t2.退出\n");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
            Console.WriteLine("请选择，输入数字：");

            Console.WriteLine("\n");

            Console.WriteLine("\t\t欢迎使用我行我素购物管理系统1.0版\n");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
            Console.WriteLine("1.客户信息管理\n");
            Console.WriteLine("2.购物结算\n");
            Console.WriteLine("3.真情回馈\n"); 
            Console.WriteLine("4.注销\n");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
            Console.WriteLine("请选择，输入数字：");


            int money = 100;
            Console.WriteLine(money);

            string name = "张三";
            char sex = '男';
            int soc = 20;
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("性别：" + sex);
            Console.WriteLine("成绩：" + soc);

            Console.WriteLine();


            string brand = "爱国者F928";
            double weight = 12.4;
            string type = "内置锂电池";
            int price = 499;
            Console.WriteLine("品牌：" + brand);
            Console.WriteLine("重量：" + weight);
            Console.WriteLine("电池类型：" + type);
            Console.WriteLine("价格：" + price);
            Console.ReadKey();
        }
    }
}