using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcdt
{
   public class Empolyee
    {

        public Empolyee(string name,string addr,int age) {
            this.Name = name;
            this.Addr = addr;
            this.age = age;
        }

        public string Name;
        public string Addr;
        public int age;


        public virtual string SayHi() {
            return "";
        }


        public string GoHome(trafficeTool tr) {

            string str = tr.Run();

            return str;
        }
    }
}
