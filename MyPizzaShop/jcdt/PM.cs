using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcdt
{
   public class PM:Empolyee
    {


        public PM(string name, string addr, int age, string pm) : base(name, addr, age)
        {
            this.pm = pm;
        }

        //经理特有的属性
        public string pm;



        public override string SayHi()
        {
            return "大家好，我叫" + this.Name + ",我来自" + this.Addr + ",我的年龄是：" + this.age + ",我是一个：" + this.pm;
        }

    }
}
