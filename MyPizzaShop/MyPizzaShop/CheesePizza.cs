using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    class CheesePizza:Pizza
    {
        public override string Prepare() 
        {
            return "׼�����ұ�����";
        }

        public override string Bake() 
        {
            return "�濾���ұ�����";
        }

        public override string Box() 
        {
            return "��װ���ұ�����";
        }
    }
}
