

using System;

namespace 第十章_类和对象
{
    class Teacher
    {
        public string name;
        public string pro;
        public string obj;
        public int teach_age;
        public void Show()
        {
            Console.WriteLine("姓名" + name);
            Console.WriteLine("专业方向" + pro);
            Console.WriteLine("教授课程" + obj);
            Console.WriteLine("教龄" + teach_age);
        }
    }
}
