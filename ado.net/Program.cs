using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Students st = new Students();
            st.Login(Console.ReadLine(), Console.ReadLine());
            Console.ReadKey();

        }
    }
}
