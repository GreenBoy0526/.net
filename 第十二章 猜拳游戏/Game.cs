using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十二章_猜拳游戏
{
    class Game
    {
        User user = new User();
        Computer computer = new Computer();
        public void initial()
        {
            while (true)
            {
                Console.WriteLine("************欢迎进入游戏世界**************");
                Console.WriteLine();
                Console.WriteLine("     ******************************");
                Console.WriteLine("     **         猜拳开始         **");
                Console.WriteLine("     ******************************");
                Console.WriteLine();
                Console.WriteLine("出拳规则：1.剪刀2.石头3.布");
                computer.Name();
                user.Name();
                Console.WriteLine(user.name + "vs" + computer.name + "对战");
                Console.WriteLine("要开始吗(y/n)");
                string start = Console.ReadLine();
                if (start == "y")
                    break;
            }
        }
        public void startGame()
        {
            int duizhancishu = 0;
            while (true)
            {
                int userchuquan = user.showFist();
                int computerchuquan = computer.showFist();
                if (userchuquan == 1)
                {
                    if (computerchuquan == 1)
                    {
                        Console.WriteLine("结果：平局");
                    }
                    else if (computerchuquan == 2)
                    {
                        Console.WriteLine("结果：输了");
                        computer.cent++;
                    }
                    else
                    {
                        Console.WriteLine("结果：赢了");
                        user.cent++;
                    }
                }
                else if (userchuquan == 2)
                {
                    if (computerchuquan == 1)
                    {
                        Console.WriteLine("结果：赢了");
                        user.cent++;
                    }
                    else if (computerchuquan == 2)
                    {
                        Console.WriteLine("结果：平局");
                    }
                    else
                    {
                        Console.WriteLine("结果：输了");
                        computer.cent++;
                    }
                }
                else
                {
                    if (computerchuquan == 1)
                    {
                        Console.WriteLine("结果：输了");
                        computer.cent++;
                    }
                    else if (computerchuquan == 2)
                    {
                        Console.WriteLine("结果：赢了");
                        user.cent++;
                    }
                    else
                    {
                        Console.WriteLine("结果：平局");
                    }
                }
                duizhancishu++;
                Console.WriteLine("是否开始下一轮（y/n）");
                string xiayilun = Console.ReadLine();
                if (xiayilun!="y")
                {
                    Console.WriteLine(user.name + "vs" + computer.name + "对战");
                    Console.WriteLine("对战次数"+duizhancishu);
                    Console.WriteLine("姓名：\t得分");
                    Console.WriteLine(user.name+"\t"+user.cent);
                    Console.WriteLine(computer.name+"\t" +computer.cent);
                    if (user.cent>computer.cent)
                    {
                        Console.WriteLine("好腻害");
                    }
                    else if (user.cent<computer.cent)
                    {
                        Console.WriteLine("垃圾");
                    }
                    else
                    {
                        Console.WriteLine("平局");
                    }
                    break;
                }
            }
            
        }
    }
}
