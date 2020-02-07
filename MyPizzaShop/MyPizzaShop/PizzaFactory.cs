using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaShop
{
    //比萨工厂
    class PizzaFactory
    {
        public static Pizza CreatePizza(string type) 
        {
            Pizza pizza =null;

            switch (type) 
            {
                case "奶酪":
                    pizza = new CheesePizza();
                    break;
                case "培根":
                    pizza = new BaconPizza();
                    break;
                default:
                    break;
            }
            return pizza;
        } 
    }
}
