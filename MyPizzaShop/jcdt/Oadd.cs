using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcdt
{
  public  class Oadd:op
    {

        public Oadd(int a,int b):base(a,b)
        {

        }

        public override int result(int a, int b)
        {
            return (a+b);
        }
    }
}
