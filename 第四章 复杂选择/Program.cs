using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章_复杂选择
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请输入成绩");
            int score = int.Parse(Console.ReadLine());
            if (score>=90)
            {
                Console.WriteLine("优秀");
            }
            else if (score>=80)
            {
                Console.WriteLine("良好");
            }
            else if (score>=60)
            {
                Console.WriteLine("中等");
            }
            else
            {
                Console.WriteLine("差");
            }
            */
            /*
            Console.WriteLine("请输入成绩");
            int score = int.Parse(Console.ReadLine());
            if (score < 10)
            {
                Console.WriteLine("请输入性别");
                string sex = Console.ReadLine();
                if (sex=="男")
                {
                    Console.WriteLine("男子组");
                }
                else
                {
                    Console.WriteLine("女子组");
                }
            }
            else
            {
                Console.WriteLine("淘汰");
            }
            */
            /*
            Console.WriteLine("是否是会员？是(y)否（其他字符）");
            string vip = Console.ReadLine();
            Console.WriteLine("输入购物金额");
            double money = double.Parse(Console.ReadLine());
            double pay;
            if (vip=="y")
            {
                if (money<200)
                {
                    pay = money * 0.8;
                }
                else
                {
                    pay = money * 0.75;
                }
            }
            else
            {
                if (money>=100)
                {
                    pay = money * 0.9;
                }
                else
                {
                    pay = money;
                }
            }
            Console.WriteLine("实际支付"+pay);
            */
            /*
            Console.WriteLine("请输入名次");
            int mc = int.Parse(Console.ReadLine());
            switch (mc)
            {
                case 1:
                    Console.WriteLine("奖励夏令营");
                    break;
                case 2:
                    Console.WriteLine("奖励笔记本");
                    break;
                case 3:
                    Console.WriteLine("奖励移动硬盘");
                    break;
                default:
                    break;
            }
            */
            /*/
            Console.WriteLine("1.登录系统");
            Console.WriteLine("2.退出");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("1.客户信息管理");
                    Console.WriteLine("2.购物结算");
                    Console.WriteLine("3.真情回馈");
                    Console.WriteLine("4.注销");
                    a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("购物管理系统>客户信息管理");
                            Console.WriteLine("1.显示所有客户信息");
                            Console.WriteLine("2.添加客户信息");
                            Console.WriteLine("3.修改客户信息");
                            Console.WriteLine("4.查询客户信息");
                            break;
                        case 3:
                            Console.WriteLine("购物管理系统>真情回馈");
                            Console.WriteLine("1.幸运大放送");
                            Console.WriteLine("2.幸运抽奖");
                            Console.WriteLine("3.生日问候");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            */
            /*
            Console.WriteLine("输入购物金额");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("是否参加优惠换购活动:");
            Console.WriteLine("1:满50元，加2元换购百事可乐饮料1瓶");
            Console.WriteLine("2:满100元，加3元换购500m1可乐-瓶");
            Console.WriteLine("3:满100元，加10元换购5公斤面粉");
            Console.WriteLine("4:满200元，加10元可换购1个苏波尔炒菜锅");
            Console.WriteLine("5:满200元，加20元可换购欧莱雅爽肤水-瓶");
            Console.WriteLine("O:不换购");
            Console.WriteLine("请选择: ");
            int list = int.Parse(Console.ReadLine());
            double pay = money;
            string product="换购失败";
            switch (list)
            {
                case 1:
                    if (money >= 50)
                    {
                        product = "成功换购:百事可乐饮料1瓶";
                        pay = money + 2;
                    }
                    break;
                case 2:
                    if (money >= 100)
                    {
                        product = "成功换购:500m1可乐-瓶";
                        pay = money + 3;
                    }
                    break;
                case 3:
                    if (money >= 100)
                    {
                        product = "成功换购:换购5公斤面粉";
                        pay = money + 10;
                    }
                    break;
                case 4:
                    if (money >= 200)
                    {
                        product = "成功换购:1个苏波尔炒菜锅";
                        pay = money + 10;
                    }
                    break;
                case 5:
                    if (money >= 200)
                    {
                        product = "成功换购:欧莱雅爽肤水-瓶";
                        pay = money + 20;
                    }
                    break;
                case 0:
                    if (money >= 50)
                    {
                        product = "已选择不换购";
                        pay = money;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("本次消费总金额：" + pay);
            Console.WriteLine(product);
            */
            /*
            Console.WriteLine("赵本山的考试成绩");
            int cj = int.Parse(Console.ReadLine());
            if(cj==100)
                Console.WriteLine("爸爸给他买辆车");
            else if (cj>=90)
                Console.WriteLine("妈妈给他买MP4");
            else if(cj>=60)
                Console.WriteLine("妈妈给他买本参考书");
            else
                Console.WriteLine("什么都不买");
                */
            Console.WriteLine("按1:拨爸爸的号");
            Console.WriteLine("按2:拨妈妈的号");
            Console.WriteLine("按3:拨爷爷的号");
            Console.WriteLine("按4:拨奶奶的号");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("拨爸爸的号");
                    break;
                case 2:
                    Console.WriteLine("拨妈妈的号");
                    break;
                case 3:
                    Console.WriteLine("拨爷爷的号");
                    break;
                case 4:
                    Console.WriteLine("拨奶奶的号");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

    }
}
