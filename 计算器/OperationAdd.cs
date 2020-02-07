using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc
{
    class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = NumberA + NumberB;
            return result;
        }
    }
}
