using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八章_抽奖系统
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] lucky = new int[5];
            for (int i = 0; i < lucky.Length; i++)
            {
                lucky[i] = rd.Next(1000,10000);
            }
            bool denglu = false;
            bool choujiang = false;
            bool zhongjiang = false;

            string name="";
            string pwd="";
            int card=0;
            while (true)
            {
                Console.WriteLine("********欢迎进入奖客富翁系统********");
                Console.WriteLine("1.注册");
                Console.WriteLine("2.登录");
                Console.WriteLine("3.抽奖");
                Console.WriteLine("************************************");
                Console.Write("请选择菜单：");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("[奖客富翁系统>注册]");
                        Console.WriteLine("请填写个人注册信息");
                        Console.Write("用户名：");
                        name = Console.ReadLine();
                        Console.Write("密码：");
                        pwd = Console.ReadLine();
                        card = rd.Next(1000, 10000);
                        Console.WriteLine("注册成功，请记好您的会员卡号");
                        Console.WriteLine("用户名\t密码\t会员卡号");
                        Console.WriteLine(name + "\t" + pwd + "\t" + card);
                        break;
                    case 2:
                        Console.WriteLine("[奖客富翁系统>登录]");
                        if (denglu)
                        {
                            Console.WriteLine("已经登录，不要重复登录");
                        }
                        else
                        {
                            for (int i = 2; i >= 0; i--)
                            {
                                Console.WriteLine("请输入用户名：");
                                string _name = Console.ReadLine();
                                if (name != _name)
                                {
                                    Console.WriteLine("用户不存在，请先注册");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("请输入密码：");
                                    string _pwd = Console.ReadLine();
                                    if (pwd == _pwd)
                                    {
                                        Console.WriteLine("欢迎您" + _name);
                                        denglu = true;
                                        break;
                                    }
                                    else
                                    {
                                        if (i == 0)
                                        {
                                            Console.WriteLine("三次机会已经用完。");
                                        }
                                        else
                                        {
                                            Console.WriteLine("密码输入错误，还有" + i + "次机会");
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("[奖客富翁系统>抽奖]");
                        if (!denglu)
                        {
                            Console.WriteLine("请先登录");
                        }
                        else if(choujiang)
                        {
                            Console.WriteLine("您已经抽过奖了");
                        }
                        else
                        {
                            choujiang = true;
                            Console.WriteLine("今天的幸运数字是：");
                            for (int i = 0; i < lucky.Length; i++)
                            {
                                Console.WriteLine(lucky[i]+"  ");
                                if (card==lucky[i])
                                {
                                    zhongjiang = true;
                                }
                            }
                            if (zhongjiang)
                            {
                                Console.WriteLine("恭喜中奖，您的卡号是"+card);
                            }
                            else
                            {
                                Console.WriteLine("抱歉，您不是本日的幸运会员");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("您的输入有误！");
                        break;
                }
                Console.Write("继续吗？（y/n）");
                string jixuma = Console.ReadLine();
                if (jixuma != "y")
                    break;
            }
            Console.WriteLine("系统退出，谢谢使用");
            Console.ReadKey();

        }
    }
}
