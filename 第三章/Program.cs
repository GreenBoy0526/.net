using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三章
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int zhangsan = 80;
             Boolean isBig;
             Console.WriteLine("请输入李四的成绩：");
             int lisi = int.Parse(Console.ReadLine());
             isBig = lisi > zhangsan;
             Console.WriteLine(isBig);
              */
            /*
          Console.WriteLine("请输入李四的成绩：");
          int lisi = int.Parse(Console.ReadLine());
          if (lisi>=0&lisi<=100)
          {
              if (lisi > 90)
                  Console.WriteLine("考的不错");
              else
                  Console.WriteLine("滚去学习");
          }
          else
              Console.WriteLine("请输入0-100");
          */

            /*
            Console.WriteLine("请输入html的成绩：");
            int html = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入音乐的成绩：");
            int music = int.Parse(Console.ReadLine());
            if (html >= 0 & html <= 100 & music >= 0 & music <= 100)
            {
                if (html > 98 & music > 80 | html == 100 & music > 70)
                    Console.WriteLine("考的不错");
                else
                    Console.WriteLine("滚去学习");
            }
            else
                Console.WriteLine("请输入0-100");
                */
            /*
        Console.WriteLine("请输入会员卡号（四位数）");
        int id = int.Parse(Console.ReadLine());
        if (id > 999 & id < 10000)
        {
            Console.WriteLine("请输入生日：");
            string bir = Console.ReadLine();

            Console.WriteLine("请输入积分：");
            int cent= int.Parse(Console.ReadLine());

            Console.WriteLine("会员信息");
            Console.WriteLine("id\t生日\t积分");
            Console.WriteLine(id+"\t"+bir+"\t" +cent);
        }
        else
            Console.WriteLine("输入四位数");
            */
            Console.WriteLine("输入a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("输入b");
            int b = int.Parse(Console.ReadLine());
            if(a%b==0|a+b>1000)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
