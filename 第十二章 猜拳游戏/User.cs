using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十二章_猜拳游戏
{
    class User
    {
        public int cent;
        public string name;
        public void Name()
        {
            Console.WriteLine("请输入你的姓名：");
            name = Console.ReadLine();
            if (name=="")
            {
                name = "匿名";
            }
        }
        public int showFist()
        {
            int chuquan;
            Console.WriteLine("请出拳（1.剪刀2.石头3.布）");
            while (true)
            {
                chuquan = int.Parse(Console.ReadLine());
                switch (chuquan)
                {
                    case 1:
                        Console.WriteLine("你出拳：剪刀");
                        break;
                    case 2:
                        Console.WriteLine("你出拳：石头");
                        break;
                    case 3:
                        Console.WriteLine("你出拳：布");
                        break;
                    default:
                        Console.WriteLine("请输入1.2.3");
                        break;
                }
                if (chuquan == 1 | chuquan == 2 | chuquan == 3)
                {
                    break;
                }
            }
            return chuquan;
        }
    }
}
