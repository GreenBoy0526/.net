using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcdt
{
  public  class op
    {

        public op(int a ,int b) {
            this.A = a;
            this.B = b;
        }

        public int A;
        public int B;


        public virtual int result(int a,int b) {
            return 0;
        }

    }
}
