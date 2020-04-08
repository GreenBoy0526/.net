using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重写_虚方法
{
    class animal
    {
       public void run()
        {
            Console.WriteLine("run");
        }
        public virtual void speak()
        {
            Console.WriteLine("speak");
        }
    }
    class Dog:animal
    {
        public override void speak()
        {
            Console.WriteLine("wang");
        }
       public void aa()
        {
            base.speak();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog cc = new Dog();
            cc.run();
            cc.speak();
            cc.aa();
            Console.ReadLine();
        }

    }
}
