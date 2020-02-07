using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cook
{
    /// <summary>
    /// 服务员类
    /// </summary>
    public class Waitress
    {
        private Order order;

        /// <summary>
        /// 记录客人的点餐

        /// </summary>
        /// <param name="order"></param>
        public void GetOrder(Order order)
        {
            this.order = order;
        }

        /// <summary>
        /// 给厨师提交菜单

        /// </summary>
        ///<param name="client">点菜顾客的对象</param>
        public void SendOrder(Chef chef)
        {
            Console.WriteLine("服务员将菜{0}传给厨师", order.mealList);
            chef.GetOrder(order);
        }

        /// <summary>
        /// 传菜
        /// </summary>
        public void TransCook()
        {
            Console.WriteLine("服务员将菜{0}送给客户{1}!",order.mealList,order.id);
            order.customer.Eat();
        }
    }
}
