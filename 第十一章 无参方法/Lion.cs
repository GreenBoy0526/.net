using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十一章_无参方法
{
    class Lion
    {
        public string color = "黄色";
        public void run()
        {
            Console.WriteLine(color+"的狮子跑");
        }
        public string bark()
        {
            string bark = "叫";
            return bark;
        }
    }
}
