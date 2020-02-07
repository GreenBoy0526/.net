using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine("第" + i + "遍，好好学习，天天向上");
                i++;
            }
            */
            /*
            string a = "n";
            while (a!="y")
            {
                Console.WriteLine("上午学习理论");
                Console.WriteLine("下午上机编程");
                Console.WriteLine("合格了吗？(y/n)");
                a = Console.ReadLine();
                if (a=="y")
                {
                    break;
                }
            }
            Console.WriteLine("恭喜合格");
            */
            /*
            int num = 0, sum = 0;
            while (num <= 100)
            {
                if (num%2==0)
                {
                    sum += num;
                }
                num++;
            }
            Console.WriteLine(sum);
            */
            /*
            int tx = 245;
            int qx = 570;
            int qp = 320;
            double money=0;
            Console.WriteLine("MyShopping管理系统 > 购物结算");
            Console.WriteLine("*************************");
            Console.WriteLine("请选择购买的商品编号:");
            Console.WriteLine("1.T恤 2.网球鞋 3.网球拍");
            Console.WriteLine("*************************");
            string flag = "y";
            while (flag == "y")
            {
                int num, price;
                Console.WriteLine("请输入商品编号:");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("请输入购买数量:");
                        num= int.Parse(Console.ReadLine());
                         price = tx * num;
                        Console.WriteLine("T恤\t￥"+tx+"\t数量"+num+ "\t小计"+price);
                        money += price;
                        break;
                    case 2:
                        Console.WriteLine("请输入购买数量:");
                        num = int.Parse(Console.ReadLine());
                        price = qx * num;
                        Console.WriteLine("网球鞋￥" + qx + "\t数量" + num + "\t小计" + price);
                        money += price;
                        break;
                    case 3:
                        Console.WriteLine("请输入购买数量:");
                        num = int.Parse(Console.ReadLine());
                        price = qp * num;
                        Console.WriteLine("网球拍￥" + qp + "\t数量" + num + "\t小计" + price);
                        money += price;
                        break;
                    default:
                        Console.WriteLine("商品不存在");
                        break;
                }
                Console.WriteLine("是否继续(y / n)");
                flag = Console.ReadLine();
            }
            Console.Write("折扣:");
            double zhekou = double.Parse(Console.ReadLine());
            money = money * zhekou;
            Console.WriteLine("应付金额"+money);
            Console.Write("实付金额");
            double pay = double.Parse(Console.ReadLine());
            if (pay>=money)
            {
                Console.WriteLine("找零"+(pay-money));
            }
            else
            {
                Console.WriteLine("不够，还缺" + (money-pay));
            }
            Console.WriteLine();
            Console.WriteLine("程序结束!");
            */
            /*
            int people = 1;
            int age;
            double old = 0;
            double young = 0;
            while (people <= 10)
            {
                Console.Write("请输入第" + people + "位顾客的年龄:");
                age = int.Parse(Console.ReadLine());
                if (age >= 30)
                    old++;
                else
                    young++;
                people++;
            }
            Console.WriteLine("三十岁以上的比例是" + (old / 10) * 100 + ".0%");
            Console.WriteLine("三十岁以下的比例是" + (young / 10) * 100 + ".0%");
            */
            /*
            int flag;
            bool is1 = true;
            Console.WriteLine("欢迎使用MyShopping管理系统");
            Console.WriteLine("**************************");
            Console.WriteLine("1.客户信息管理");
            Console.WriteLine("2.购物结算");
            Console.WriteLine("3.真情回馈");
            Console.WriteLine("4.注销");
            Console.WriteLine("**************************");
            Console.Write("请选择，输入数字: ");
            do
            {
                if (is1 == false)
                    Console.Write("输入错误，请重新输入数字:");
                flag = int.Parse(Console.ReadLine());
                is1 = false;
            } while ((flag != 1) & (flag != 2) & (flag != 3) & (flag != 4));

            switch (flag)
            {
                case 1:
                    Console.WriteLine("执行客户信息管理");
                    break;
                case 2:
                    Console.WriteLine("执行购物结算");
                    break;
                case 3:
                    Console.WriteLine("执行真情回馈");
                    break;
                case 4:
                    Console.WriteLine("执行注销");
                    break;
                default:
                    break;
            }
            */
            int id = 456789123;
            int pwd = 123456;
            double money = 100000;
            int cishu = 3;
            while (cishu > 0)
            {
                Console.WriteLine("输入卡号");
                int _id = int.Parse(Console.ReadLine());
                Console.WriteLine("输入密码");
                int _pwd = int.Parse(Console.ReadLine());
                if (id == _id & _pwd == pwd)
                {
                    Console.WriteLine("登录成功");

                    while (true)
                    {
                        Console.WriteLine("余额：" + money);
                        Console.WriteLine("请选择要办理的业务：1.取款\t2.存款\t3.退出");
                        int yewu = int.Parse(Console.ReadLine());
                        switch (yewu)
                        {
                            case 1:
                                Console.WriteLine("请输入取款金额");
                                double qukuan = double.Parse(Console.ReadLine());
                                if (qukuan <= money)
                                {
                                    money -= qukuan;
                                    Console.WriteLine("取款成功,余额" + money);
                                }
                                else
                                {
                                    Console.WriteLine("余额不足,余额" + money);
                                }
                                break;
                            case 2:
                                Console.WriteLine("请输入存款金额");
                                double cunkuan = double.Parse(Console.ReadLine());
                                money += cunkuan;
                                Console.WriteLine("存款成功,余额" + money);
                                break;
                            case 3:
                                Console.WriteLine("再见");
                                break;
                            default:
                                Console.WriteLine("请选择编号");
                                break;
                        }
                        if (yewu == 3)
                        {
                            break;
                        }

                    }
                    break;
                }
                else
                {
                    cishu--;
                    if (cishu == 0)
                    {
                        Console.WriteLine("三次密码均输入错误，卡已被锁定，请携带有效证件到柜台办理。");
                        break;
                    }
                    Console.WriteLine("输入错误，还有" + cishu + "次机会");
                }
            }

            Console.ReadKey();
        }
    }
}
