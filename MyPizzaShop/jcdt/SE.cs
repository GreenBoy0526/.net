using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcdt
{
   public class SE
    {


        public SE(string name, string addr, string age)
        {
            this.Name = name;
            this.Addr = addr;
            this.Age = age;
        }

        public string Age { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Addr { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        //程序员特有的属性
        public string se;


        //public override string SayHi() {
        //    return "大家好，我叫"+this.Name+",我来自"+this.Addr+",我的年龄是："+this.age+",我是一个："+this.se;
        //}
    }
}
