using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish
{
    class Card
    {
        private string _suit;
        private string _rank;
        private string _name;

        public Card(int suit, int rank)
        {
            _suit = SetSuit(suit);
            _rank = SetRank(rank);
            _name = _rank + " of " + _suit;
            
        }
        public string SetSuit(int suit)
        {
            switch (suit)
            {
                case 0:
                    return "Spades";
                case 1:
                    return "Hearts";
                case 2:
                    return "Diamonds";
                default:
                    return "Clubs";
            }
        }
        public string SetRank(int rank)
        {
            switch (rank)
            {
                case 0:
                    return "Ace";
                case 1:
                    return "2";
                case 2:
                    return "3";
                case 3:
                    return "4";
                case 4:
                    return "5";
                case 5:
                    return "6";
                case 6:
                    return "7";
                case 7:
                    return "8";
                case 8:
                    return "9";
                case 9:
                    return "10";
                case 10:
                    return "J";
                case 11:
                    return "Q";
                default:
                    return "K";
            }
        }
        public string GetSuit { get { return _suit; } }
        public string GetRank { get { return _rank; } }
        public string GetName { get { return _name; } }
    }
}

