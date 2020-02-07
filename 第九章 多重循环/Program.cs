using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八章_多重循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 3; i++)
            {
                double sum = 0;
                Console.WriteLine("请输入第"+i+"个班级的成绩");
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("请输入第"+j+"个学生的成绩");
                    double sc = double.Parse(Console.ReadLine());
                    sum += sc;
                }
                Console.WriteLine("平均分："+sum/4);
            }
            */
            /*
            Console.WriteLine("直角三角形");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            /*
             Console.Write("请输入直角三角形的行数：");
             int line = int.Parse(Console.ReadLine());
             for (int i = 0; i <line; i++)
             {
                 for (int j = 0; j < i*2+1; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             */
            /*
            Console.Write("请输入直角三角形的行数：");
            int line = int.Parse(Console.ReadLine());
            for (int i = line; i >0; i--)
            {
                for (int j = i; j >0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            /*
            Console.Write("请输入等腰三角形的高度：");
            int line = int.Parse(Console.ReadLine());
            for (int i = 0; i <line; i++)
            {
                for (int j = line-i; j>1 ; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            /*
            Console.Write("请输入菱形行数：");
            int line;
            while (true)
            {
                line = int.Parse(Console.ReadLine());
                if (line % 2 != 0)
                {
                    break;
                }
                Console.WriteLine("请输入奇数");
            }
            for (int i = 0; i < line/2+1; i++)
            {
                for (int j = 0; j < line/2-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i*2+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < line / 2; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < line-(i+1)*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            /*
            int sum = 0;
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("欢迎光临第"+i+"家店");
                while (true)
                {
                    Console.WriteLine("离开？（y/n）");
                    string flag = Console.ReadLine();
                    if (flag=="n")
                    {
                        sum += 1;
                        Console.WriteLine("买了一件衣服");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("共买了"+sum+"件衣服");
            */
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+"*"+j+"="+i*j+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
