using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    abstract class Pizza
    {
        //׼��
        public abstract string Prepare();

        //�濾
        public abstract string Bake();

        //��װ
        public abstract string Box();
    }
}
