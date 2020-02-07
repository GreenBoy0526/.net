using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_类和对象
{
    class youren
    {
        public string name;
        public int age;
        public int price;
        public void Show()
        {
            
            Console.Write("请输入年龄：");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
                price = 20;
            else
                price = 0;
            Console.WriteLine(name+"的年龄为"+age+"，门票价格为："+price+"元");
        }
    }
}
