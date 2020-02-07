using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串大小写转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aaaaAAaaaa";
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine(a);
            Console.WriteLine("----------");
            char c = 'a';
            Console.WriteLine(char.ToUpper(c));
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
