using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //大小写转换
            string a = "aaaaAAaaaa";
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine(a);
            Console.WriteLine("----------");
            char c = 'a';
            Console.WriteLine(char.ToUpper(c));
            Console.WriteLine(c);
            Console.WriteLine("===========");

            //字符串比较== ！= Equals
            

            //字符串比较Compare
            string s1 = "aa";
            string s2 = "bb";
            Console.WriteLine(string.Compare(s1,s2));

            string s3 = "AA";
            Console.WriteLine(string.Compare(s1,s3));
            Console.WriteLine(string.Compare(s1, s3,true));//true用来忽略大小写
            //字符串比较CompareTo
            Console.WriteLine(s1.CompareTo(s3));
            Console.ReadKey();
        }
    }
}
