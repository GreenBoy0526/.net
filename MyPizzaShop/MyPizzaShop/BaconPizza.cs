using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    class BaconPizza:Pizza
    {
        public override string Prepare()
        {
            return "准备培根比萨！";
        }

        public override string Bake()
        {
            return "烘烤培根比萨！";
        }

        public override string Box()
        {
            return "包装培根比萨！";
        }
    }
}
