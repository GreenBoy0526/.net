using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySchoolBase
{
    class Program
    {
        static void Main(string[] args)
        {

            School sc = new School();
            sc.Login();
            Console.ReadKey();
        }
    }
}