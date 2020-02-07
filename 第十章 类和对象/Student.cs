using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_类和对象
{
    class Student
    {
        public string name;
        public int age;
        public int _class;
        public string hobby;
        public void Show()
        {
            Console.WriteLine("姓名"+name);
            Console.WriteLine("年龄" +age);
            Console.WriteLine("班级" +_class);
            Console.WriteLine("爱好" +hobby);
        }
    }
}
