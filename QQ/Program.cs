﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ
{
    class Program
    {
        static void Main(string[] args)
        {
            QQMgr qq = new QQMgr();
            qq.Login();
            Console.ReadKey();
        }
    }
}
