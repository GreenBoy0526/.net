using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cook
{
    public class Client
    {
        /// <summary>
        /// 点菜
        /// </summary>
        public void Order(Waitress waitress,Order order)
        {
            Console.WriteLine("顾客开始点菜:{0}!", order.mealList);
            waitress.GetOrder(order);
        }

        /// <summary>
        /// 用餐
        /// </summary>
        public void Eat() 
        {
            Console.WriteLine("客人用餐！");
        }

    }
}
