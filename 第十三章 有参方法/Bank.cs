using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十三章_有参方法
{
    class Bank
    {
        public double money = 0;
        public void menu()
        {
            while (true)
            {
                Console.WriteLine("1.存款2.取款0.退出");
                Console.WriteLine("请选择你需要办理的业务");
                string xuanxiang = Console.ReadLine();
                if (xuanxiang == "1")
                {
                    cunKuan();
                }
                else if (xuanxiang == "2")
                {
                    quKuan();
                }
                else if (xuanxiang == "0")
                    break;
                else
                    Console.WriteLine("非法输入"); 

                Console.WriteLine("当前金额" + money);
                Console.WriteLine();
            }
        }
        public void cunKuan()
        {
            Console.WriteLine("请输入存款金额");
            double jine = double.Parse(Console.ReadLine());
            money += jine;
            Console.WriteLine("存款成功");
        }
        public void quKuan()
        {
            Console.WriteLine("请输入取款金额");
            double jine = double.Parse(Console.ReadLine());
            if (jine<money)
            {
                money -= jine;
                Console.WriteLine("取款成功");
            }
            else
                Console.WriteLine("金额不足");
        }
    }
}
