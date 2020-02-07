using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十三章_有参方法
{
    class PrintSanjiaoxing
    {
        public void print(int height,string zifu)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(zifu);
                }
                Console.WriteLine();
            }
        }
    }
}
