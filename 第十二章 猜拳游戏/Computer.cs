using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十二章_猜拳游戏
{
    class Computer
    {
        public int cent;
        public string name;
        public void Name()
        {
            Console.WriteLine("请选择对方角色（1.刘备2.孙权3.曹操）");
            while (true)
            {
                int juese = int.Parse(Console.ReadLine());
                switch (juese)
                {
                    case 1:
                        name = "刘备";
                        break;
                    case 2:
                        name = "孙权";
                        break;
                    case 3:
                        name = "曹操";
                        break;
                    default:
                        Console.WriteLine("角色不存在，请重新选择");
                        break;
                }
                if (juese == 1 | juese == 2 | juese == 3)
                {
                    break;
                }
            }
            Console.WriteLine("你选择了"+name+"对战");
        }
        public int showFist()
        {
            Random rd = new Random();
            int chuquan = rd.Next(1, 4);
            switch (chuquan)
            {
                case 1:
                    Console.WriteLine(name + "出拳：剪刀");
                    break;
                case 2:
                    Console.WriteLine(name + "出拳：石头");
                    break;
                case 3:
                    Console.WriteLine(name + "出拳：布");
                    break;
                default:
                    break;
            }
            return chuquan;
        }
    }
}
