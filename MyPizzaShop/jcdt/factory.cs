using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcdt
{
   public class factory
    {
        option od;
        /// <summary>
        /// 当我的FuHao传进来的时候（+），case +
        /// </summary>
        /// <param name="FuHao"></param>
        /// <returns></returns>
        public option CaoZuo(string FuHao) {

            switch (FuHao)
            {
                case "+":

                    od = new JJCC();

                    break;
                case "-":

                    od = new Jian();

                    break;
                default:
                    break;
            }


            return od;

        }
    }
}
