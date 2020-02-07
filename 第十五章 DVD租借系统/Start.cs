using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十五章_DVD租借系统
{
    class Start
    {
        static void Main(string[] args)
        {
            DVDMgr mgr = new DVDMgr();
            mgr.initial();
            startMenu(mgr);
            Console.ReadKey();
        }
        public static void startMenu(DVDMgr mgr)
        {
            Console.WriteLine("欢迎使用MiniDVD管理器");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0.借出排行榜");
            Console.WriteLine("1.新增DVD");
            Console.WriteLine("2.查看DVD");
            Console.WriteLine("3.删除DVD");
            Console.WriteLine("4.借出DVD");
            Console.WriteLine("5.归还DVD");
            Console.WriteLine("6.退出");
            Console.WriteLine("-------------------------------");
            Console.Write("请选择");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "0":
                    Console.WriteLine("------->借出排行榜");
                    mgr.paiHnag();
                    break;
                case "1":
                    Console.WriteLine("------->新增DVD");
                    mgr.addDVD();
                    break;
                case "2":
                    Console.WriteLine("------->查看DVD");
                    mgr.showDVD();
                    break;
                case "3":
                    Console.WriteLine("------->删除DVD");
                    mgr.delDVD();
                    break;
                case "4":
                    Console.WriteLine("------->借出DVD");
                    mgr.jieChu();
                    break;
                case "5":
                    Console.WriteLine("------->归还DVD");
                    mgr.returnDVD();
                    break;
                case "6":
                    Console.WriteLine("------->退出");
                    break;
                default:
                    Console.WriteLine("选择错误");
                    break;
            }
            returnMain(mgr);
        }
        public static void returnMain(DVDMgr mgr)
        {
            Console.Write("输入0返回");
            string fanhui = Console.ReadLine();
            if (fanhui=="0")
            {
                startMenu(mgr);
            }else
                Console.WriteLine("再见");
        }
        
    }
}
