using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cook
{
    public class Chef
    {
        private Order order;
        /// <summary>
        /// 
        /// </summary>
        public void GetOrder(Order order) 
        {
            this.order = order;
        }

         /// <summary>
         /// 厨师做菜
         /// </summary>
         /// <param name="waitress">服务员</param>
         /// <param name="client">客户</param>
        public void Cook()
        {
            Console.WriteLine("厨师烹制:{0}",order.mealList);
            Console.WriteLine("制作完毕");
        }

        /// <summary>
        /// 提醒饭菜制作完毕
        /// </summary>
        /// <param name="waitress"></param>
        public void SendAlert(Waitress waitress)
        {
            Console.WriteLine("厨师提示服务员取菜！");
            waitress.GetOrder(order);
        }
    }
}
