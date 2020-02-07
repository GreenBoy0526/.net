using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    abstract class Pizza
    {
        //准备
        public abstract string Prepare();

        //烘烤
        public abstract string Bake();

        //包装
        public abstract string Box();
    }
}
