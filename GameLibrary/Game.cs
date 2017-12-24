using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        public List<Player> player { get; set; }
        public List<Karta> karta { get; set; }
        
        public Game(List<Player> plyaer, List<Karta> card)
        {
            player = plyaer;
            karta = card;
        }
    }
}
