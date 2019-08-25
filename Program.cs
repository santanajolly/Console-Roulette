using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8A___Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Bet bet = new Bet();
            Game game = new Game();
            player.Start();
        }
    }
}
