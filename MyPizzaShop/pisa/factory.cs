using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisa
{
   public class factory
    {
        pisaPar pa = null;
        public pisaPar show(string o)
        {
            switch (o)
            {
                case "奶酪":
                    pa = new NaiLao();
                    break;
                case "培根":
                    pa = new PeiGen();
                    break;
                default:
                    break;
            }

            return pa;
        }
    }
}
