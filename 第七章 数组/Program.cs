using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七次课_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double[] sc = new double[5];
            double sum = 0;
            for (int i = 0; i < sc.Length; i++)
            {
                Console.WriteLine("请输入第"+(i + 1)+"名同学的成绩");
                sc[i] = double.Parse(Console.ReadLine());
                sum += sc[i];
            }
            double av = sum / sc.Length;
            Console.WriteLine("平均分是"+av);
            */
            /*
            int[] num = { 8, 4, 2, 1, 23, 344, 12 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]+",");
                sum += num[i];
            }
            Console.WriteLine("数组中的和是:"+sum);
            Console.WriteLine("请输入一个数字: ");
            int _num = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < num.Length; i++)
            {
                if (_num == num[i])
                {
                    Console.WriteLine("数组中包含"+ _num);
                    flag = true;
                    break;
                }
            }
            if(flag==false)
                Console.WriteLine("数组中不包含" + _num);
                */
            /*
        string[] shangpin = { "Nike背包", "Adidas运动衫", "李宁运动鞋", "Kappa外套", "361 °腰包" };
        Console.WriteLine("本次活动特价商品有:");
        for (int i = 0; i < shangpin.Length; i++)
        {
            Console.WriteLine(shangpin[i]);
        }
        */
            /*
        double[] money = new double[5];
        double sum = 0;
        for (int i = 0; i < money.Length; i++)
        {
            Console.Write("请输入第" + (i + 1) + "笔购物金额：");
            money[i] = double.Parse(Console.ReadLine());
            sum += money[i];
        }
        Console.WriteLine("序号\t金额");
        for (int i = 0; i < money.Length; i++)
        {
            Console.WriteLine((i+1)+"\t"+money[i]);
        }
        Console.WriteLine("总金额\t"+sum);
        */
            /*
                char[] zifu = { 'a', 'c', 'u', 'b', 'e', 'p', 'f', 'z' };
                for (int i = 0; i < zifu.Length; i++)
                {
                    Console.Write(zifu[i] + "  ");
                }
                Console.WriteLine();
                Array.Sort(zifu);
                for (int i = 0; i < zifu.Length; i++)
                {
                    Console.Write(zifu[i] + "  ");
                }
                Console.WriteLine();
                for (int i = zifu.Length - 1; i >= 0; i--)
                {
                    Console.Write(zifu[i] + "  ");
                }
                */
            /*
        Console.WriteLine("输入四家店的价格：");
        int[] price = new int[4];
        Console.Write("第1家店的价格：");
        price[0] = int.Parse(Console.ReadLine());
        int mix = price[0];
        for (int i = 1; i < price.Length; i++)
        {
            Console.Write("第"+(i+1)+"家店的价格：");
            price[i] = int.Parse(Console.ReadLine());
            if (price[i] < mix)
                mix = price[i];
        }
        Console.WriteLine("最低价格是"+mix);
        */
        /*
            int[] cent = new int[5];
            Console.WriteLine("请输入五位会员的积分：");
            for (int i = 0; i < cent.Length; i++)
            {
                Console.Write("第"+(i+1)+"位");
                cent[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("序号\t历史积分\t新年积分");
            int[] newYear = new int[5];
            for (int i = 0; i < cent.Length; i++)
            {
                newYear[i] = cent[i] + 500;
                Console.WriteLine((i + 1) + "\t" + cent[i] + "\t\t"+newYear[i]);
            }
          */

            Console.ReadKey();
        }
    }
}
