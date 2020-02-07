using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十二章_猜拳游戏
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.initial();
            game.startGame();
            Console.ReadKey();
        }
    }
}
