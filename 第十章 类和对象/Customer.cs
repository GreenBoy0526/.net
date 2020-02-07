using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_类和对象
{
    class Customer
    {
        public int cent;
        public string cardType;
        public void Show()
        {
            Console.WriteLine("积分:"+cent);
            Console.WriteLine("卡类型："+cardType);
        }
    }
}
