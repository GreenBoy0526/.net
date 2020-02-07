using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck t = new Truck("a","b");
            Truck tr = new Truck();
            Console.WriteLine(tr.TruckRun()); 
            Console.WriteLine(t.TruckRun());

            Console.Read();
        }
    }
}
