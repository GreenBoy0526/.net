using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_类和对象
{
    class Administrator
    {
        public string id;
        public string pwd;
        public void Show()
        {
            Console.WriteLine("用户名：" + id);
            Console.WriteLine("密码：" + pwd);
        }
        public void xiuGaiMiMa()
        {
            while (true)
            {
                string pass;
                Console.WriteLine("请输入旧密码");
                pass = Console.ReadLine();
                if (pass == pwd)
                {
                    while (true)
                    {
                        Console.WriteLine("请输入新密码");
                        pass = Console.ReadLine();
                        Console.WriteLine("确认密码");
                        string pass1 = Console.ReadLine();
                        if (pass==pass1)
                        {
                            pwd = pass1;
                            break;
                        }
                        else
                            Console.WriteLine("密码不一致");
                    }
                    break;
                }
                else
                    Console.WriteLine("密码输入错误");
            }
            Console.WriteLine("用户名：" + id);
            Console.WriteLine("密码：" + pwd);
        }
    }
}
