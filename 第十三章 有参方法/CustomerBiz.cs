using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十三章_有参方法
{
    class CustomerBiz
    {
        string[] names = new string[10];
        public int num = 0;

        public void addName(string name)
        {

            if (num == names.Length)
            {
                Console.WriteLine("已存满");
                return;
            }
            names[num] = name;
            num++;

        }


        public void showNames()
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(names[i] + " ");
            }
        }
        public Boolean search(String name)
        {
            bool find = false;
            for (int i = 0; i < num; i++)
            {
                if (name == names[i])
                {
                    find = true;
                }
            }
            return find;
        }
        public bool updateName(string oldname,string newname)
        {
            bool find = false;
            for (int i = 0; i < num; i++)
            {
                if (oldname == names[i])
                {
                    names[i] = newname;
                    find = true;
                }
            }
            return find;
        }
    }
}
