using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十四章_对象作为参数
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Student stu = new Student();
            Console.Write("输入database成绩");
            stu.database = double.Parse(Console.ReadLine());
            Console.Write("输入html成绩");
            stu.html = double.Parse(Console.ReadLine());
            Console.Write("输入Java成绩");
            stu.java = double.Parse(Console.ReadLine());
            Score sc = new Score();
            sc.getSum(stu);
            sc.getAvg(stu);
            */
            MyShopping shopping = new MyShopping();
            shopping.Add();
            shopping.showCust();
            if (shopping.findCust()==false)
            {
                Console.WriteLine("没找到");
            }
            Console.ReadKey();
        }
    }
}
