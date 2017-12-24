using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Karta
    {
        public const int countOfCards = 36;

        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Karta(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public int CardsToPerson(Player plyaer)
        {
            return plyaer.CountOfPlayers / countOfCards;
        }

    }
}
