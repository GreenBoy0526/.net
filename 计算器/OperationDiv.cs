using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc
{
    class OperationDiv:Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0！");
            }
            double result = NumberA / NumberB;
            return result;
        }
    }
}
