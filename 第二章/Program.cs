using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("请输入html的成绩：");
            double html = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入db的成绩：");
            double db = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入c的成绩：");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.WriteLine("html\tdb\tc");
            Console.WriteLine(html+"\t"+db+"\t"+c);
            Console.WriteLine("-------------------------");
            double cha;
            if (html > db)
                cha = html - db;
            else
                cha = db - html;
            Console.WriteLine("html和db的差是："+cha);
            double avg = (html + db + c) / 3;
            Console.WriteLine("平均成绩是："+avg);
            

            int day = 46;
            int week = day / 7;
            Console.WriteLine(day+"天共有"+week+"周，剩余"+(day%7)+"天");


            double pi = 3.1415926;
            double radius = 1.5;
            double area = pi * radius * radius;
            Console.WriteLine("圆的面积是："+area);


            Console.WriteLine("请输入密码:");
            int pwd =int.Parse(Console.ReadLine());
            int newpwd = (pwd * 10 + 5) / 2 + (int)3.14159;
            Console.WriteLine("加密后的密码是："+newpwd);*/


            int tx = 245;
            int qx = 570;
            int qp = 320;
            Console.WriteLine("输入T恤购买数量:");
            int txn = int.Parse(Console.ReadLine());
            int txm = tx * txn;
            Console.WriteLine("输入网球鞋购买数量:");
            int qxn = int.Parse(Console.ReadLine());
            int qxm = qx * qxn;
            Console.WriteLine("输入网球拍购买数量:");
            int qpn = int.Parse(Console.ReadLine());
            int qpm = qp * qpn;
            Console.WriteLine("* * * * 购物清单 * * * *");
            Console.WriteLine("购买物品\t单价\t数量\t金额");
            Console.WriteLine("T恤\t\t￥" + tx + "\t" + txn + "\t￥" + txm);
            Console.WriteLine("网球鞋\t\t￥" + qx + "\t" + qxn + "\t￥" + qxm);
            Console.WriteLine("网球拍\t\t￥" + qp + "\t" + qpn + "\t￥" + qpm);
            Console.Write("折扣：");
            double zk = double.Parse(Console.ReadLine());
            double zongjine = (txm + qxm + qpm) * zk;
            Console.WriteLine("消费总金额:￥" + zongjine);
            Console.Write("付钱：");
            int mon = int.Parse(Console.ReadLine());
            Console.WriteLine("找零：￥" + (mon - zongjine));

            
            Console.ReadLine();
        }
    }
}
