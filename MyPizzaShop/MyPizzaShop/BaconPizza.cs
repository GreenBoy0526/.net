using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    class BaconPizza:Pizza
    {
        public override string Prepare()
        {
            return "׼�����������";
        }

        public override string Bake()
        {
            return "�濾���������";
        }

        public override string Box()
        {
            return "��װ���������";
        }
    }
}
