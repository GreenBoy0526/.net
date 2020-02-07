using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十五章_DVD租借系统
{
    class DVDMgr
    {
        DVDSet[] dvds = new DVDSet[30];
        int num;
        public void initial()
        {
            DVDSet dvd0 = new DVDSet();
            dvd0.name = "哪吒传奇";
            dvd0.state = 0;
            dvd0.lent_date = DateTime.Parse("2019-7-1");
            dvd0.count = 1;
            dvds[0] = dvd0;

            DVDSet dvd1 = new DVDSet();
            dvd1.name = "烈火英雄";
            dvd1.state = 1;
            dvds[1] = dvd1;

            DVDSet dvd2 = new DVDSet();
            dvd2.name = "银河补习班";
            dvd2.state = 1;
            dvds[2] = dvd2;
            num = 3;
        }
        public void showDVD()
        {
            Console.WriteLine("序号\t名称\t\t状态\t日期");
            for (int i = 0; i < num; i++)
            {
                string date;
                if (string.Format("{0:d}", dvds[i].lent_date) == "0001/1/1")
                {
                    date = "";
                }
                else
                    date = string.Format("{0:d}", dvds[i].lent_date);
                Console.WriteLine((i + 1) + "\t" + dvds[i].name + "\t" + search(dvds[i].state) + "\t" + date);
            }
        }
        public string search(int state)
        {

            if (state == 0)
            {
                return "已借出";
            }
            else
                return "可借";
        }
        public void addDVD()
        {
            DVDSet dvd = new DVDSet();
            Console.WriteLine("输入新增DVD名称：");
            dvd.name = Console.ReadLine();
            dvd.state = 1;
            dvds[num] = dvd;
            num++;
        }
        public void delDVD()
        {
            Console.WriteLine("输入删除DVD名称：");
            string name = Console.ReadLine();
            bool find = false;
            for (int i = 0; i < num; i++)
            {
                if (name == dvds[i].name & dvds[i].state != 0)
                {
                    for (int j = i; j < num; j++)
                    {
                        dvds[j] = dvds[j + 1];
                    }
                    if (num == dvds.Length)
                    {
                        dvds[num] = null;
                    }
                    Console.WriteLine("删除成功");
                    num--;
                    find = true;
                    break;
                }
                else if (name == dvds[i].name & dvds[i].state == 0)
                {
                    Console.WriteLine("已借出，无法删除");
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                Console.WriteLine("没有这个DVD");
            }
        }
        public void jieChu()
        {
            Console.WriteLine("输入借出DVD名称：");
            string name = Console.ReadLine();
            bool find = false;
            for (int i = 0; i < num; i++)
            {
                if (name == dvds[i].name & dvds[i].state != 0)
                {
                    dvds[i].state = 0;
                    Console.WriteLine("请输入日期：");
                    dvds[i].lent_date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("借出《" + dvds[i].name + "》成功");
                    dvds[i].count++;
                    find = true;
                    break;
                }
                else if (name == dvds[i].name & dvds[i].state == 0)
                {
                    Console.WriteLine("已借出");
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                Console.WriteLine("没有这个DVD");
            }
        }
        public void returnDVD()
        {
            Console.WriteLine("输入归还DVD名称：");
            string name = Console.ReadLine();
            bool find = false;
            for (int i = 0; i < num; i++)
            {
                if (name == dvds[i].name & dvds[i].state == 0)
                {
                    dvds[i].state = 1;
                    Console.WriteLine("请输入日期：");
                    DateTime return_date = DateTime.Parse(Console.ReadLine());
                    TimeSpan sp = return_date.Subtract(dvds[i].lent_date);
                    Console.WriteLine("归还《" + dvds[i].name + "》成功");
                    Console.WriteLine("借出日期" + string.Format("{0:d}", dvds[i].lent_date));
                    Console.WriteLine("归还日期" + string.Format("{0:d}", return_date));
                    Console.WriteLine("租金" + sp.Days);
                    find = true;
                    break;
                }
                else if (name == dvds[i].name & dvds[i].state == 1)
                {
                    Console.WriteLine("已归还，不要重复归还");
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                Console.WriteLine("没有这个DVD");
            }
        }
        public void paiHnag()
        {
            DVDSet[] dvd_paihang = new DVDSet[30];
            for (int i = 0; i < num; i++)
            {
                dvd_paihang[i] = dvds[i]; 
            }
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num-1-i; j++)
                {
                    if (dvd_paihang[j].count<dvd_paihang[j+1].count)
                    {
                        DVDSet a = dvd_paihang[j];
                        dvd_paihang[j] = dvd_paihang[j + 1];
                        dvd_paihang[j + 1] = a;
                    }
                    
                }
            }
            Console.WriteLine("次数\t名称");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(dvd_paihang[i].count+"\t"+ dvd_paihang[i].name);
            }
        }
    }
}