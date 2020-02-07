using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Vechcle
    {
        protected string type;//类型
        protected string place;//产地
        public Vechcle(string type,string place)
        {
            this.type = type;
            this.place = place;
        }
        public Vechcle() { }
        public string VechcleRun()
        {

            return "汽车在行驶";
        }
    }
}
