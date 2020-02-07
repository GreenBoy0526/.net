using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_类和对象
{
    class School
    {
        public string name;
        public int class_num;
        public int lab_num;
        public void Show()
        {
            Console.WriteLine("学校名称"+name);
            Console.WriteLine("教室数量"+class_num);
            Console.WriteLine("机房数量"+lab_num);
        }
    }
}
