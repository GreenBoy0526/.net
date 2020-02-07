using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Truck : Vechcle
    {
        public Truck(string type, string place) : base(type, place)
        {
        }
        public Truck()
        {
            this.type = "c";
            place = "d";
        }
        public string TruckRun()
        {

            return "型号" + type + "产地" + place + "的卡车在行驶";
        }
    }
}
