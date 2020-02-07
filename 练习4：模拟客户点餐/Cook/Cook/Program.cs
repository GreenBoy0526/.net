﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/***
 * 
 * 顾客（Client），服务员(Waitress),厨师 对象之间协作以完成点菜过程。

 * 假设一个顾客的服务员负责将顾客点的菜传给厨师，并把做好的菜传给这个顾客。

 * **/
namespace Cook
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化客户、服务员、厨师

            Client wang = new Client();
            
            Waitress  waitress = new Waitress();
            Waitress zhang = new Waitress();
            Chef  chef = new Chef();

            //初始化点菜单
            Order order = new Order();
            order.customer = wang;
            order.id = 100;
            order.mealList = "水煮鱼";

            //顾客client选中waitress服务员给自己服务
            wang.Order(waitress,order);

            //服务员将菜单信息告知厨师chef
            waitress.SendOrder(chef);

            //厨师根据菜单做菜
            chef.Cook();
            chef.SendAlert(zhang);
            zhang.TransCook();
            
            Console.Read();

        }
    }
}
