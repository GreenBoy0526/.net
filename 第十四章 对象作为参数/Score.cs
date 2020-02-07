using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十四章_对象作为参数
{
    class Score
    {
        public void getSum(Student stu)
        {
            Console.WriteLine("总成绩是"+ (stu.database + stu.html + stu.java));
        }
        public void getAvg(Student stu)
        {
            Console.WriteLine("平均分是" + (stu.database + stu.html + stu.java)/3);
        }
    }
}
