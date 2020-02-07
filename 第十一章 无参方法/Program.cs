using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十一章_无参方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Lion lion = new Lion();
            lion.run();
            Console.WriteLine(lion.color+"的狮子"+lion.bark());
            */
            chengji cj = new chengji();
            cj.shuru();
            cj.getSum();
            cj.getAvg();
            Console.ReadKey();
        }
    }
}
