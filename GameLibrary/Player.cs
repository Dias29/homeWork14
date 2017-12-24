using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player
    {
        public int CountOfPlayers { get; set; }
        public string Name { get; set; }
        public List<Karta> Karta { get; set; }

        public Player(List<Karta> card, Player player)
        {
            Karta karta =(Karta) card;
            Karta = AvailableCards( card, player);
        }

        public int AvailableCards(Karta card, Player player)
        {
            return card.CardsToPerson(player);
        }




    }
}
