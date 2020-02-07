using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十四章_对象作为参数
{
    class MyShopping
    {
        Customer[] cus = new Customer[10];
        public int num = 0;

        public void Add()
        {
            if (num == cus.Length)
            {
                Console.WriteLine("已存满");
            }
            else
            {
                for (int i = num; i < cus.Length; i++)
                {
                    Customer cu = new Customer();
                    Console.Write("请输入会员编号：");
                    cu.no = Console.ReadLine();
                    Console.Write("请输入会员积分：");
                    cu.points = int.Parse(Console.ReadLine());
                    cus[i] = cu;
                    num++;
                    Console.Write("继续？（y/n）");
                    string goon = Console.ReadLine();
                    if (goon != "y")
                    {
                        break;
                    }
                }
            }

        }
        public void showCust()
        {
            Console.WriteLine("编号\t积分");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(cus[i].no+"\t"+cus[i].points);
            }
        }
        public bool findCust()
        {
            bool isFind = false;
            Console.Write("请输入会员编号：");
            string no = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {
                if (no==cus[i].no)
                {
                    Console.WriteLine("编号"+no+"的积分是"+cus[i].points);
                    isFind = true;
                    break;
                }
            }
            return isFind;
        }
    }
}
