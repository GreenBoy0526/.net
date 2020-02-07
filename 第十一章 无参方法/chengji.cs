using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十一章_无参方法
{
    class chengji
    {
        public double java;
        public double cs;
        public double db;

        public void shuru()
        {
            Console.WriteLine("请输入Java成绩：");
            java = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入cs成绩：");
            cs = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入DB成绩：");
            db = double.Parse(Console.ReadLine());
        }
        public void getSum()
        {
            Console.WriteLine("总成绩是："+(java+cs+db));
        }
        public void getAvg()
        {
            Console.WriteLine("平均成绩是：" + (java + cs + db)/3);
        }
    }
}
