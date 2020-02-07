using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    //��������
    class PizzaFactory
    {
        public static Pizza CreatePizza(string type) 
        {
            Pizza pizza =null;

            switch (type) 
            {
                case "����":
                    pizza = new CheesePizza();
                    break;
                case "���":
                    pizza = new BaconPizza();
                    break;
                default:
                    break;
            }
            return pizza;
        } 
    }
}
