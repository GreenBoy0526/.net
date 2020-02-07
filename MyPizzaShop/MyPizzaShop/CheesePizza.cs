using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    class CheesePizza:Pizza
    {
        public override string Prepare() 
        {
            return "准备奶酪比萨！";
        }

        public override string Bake() 
        {
            return "烘烤奶酪比萨！";
        }

        public override string Box() 
        {
            return "包装奶酪比萨！";
        }
    }
}
