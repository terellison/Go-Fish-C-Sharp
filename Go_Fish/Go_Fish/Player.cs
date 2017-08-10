using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish
{
    class Player
    {
        private string _name;
        private List<Card> _cardsInHand;
        int _book = 0;

        public Player(string name)
        {
            _name = name;
        }

        public void DrawCard(Card[] deck)
        {
            Random randCard = new Random();
            int drawCard = randCard.Next(deck.Length + 1);
            _cardsInHand.Add(deck[drawCard]);

        }

        public bool AskForCardRank(string rank)
        {
            foreach(Card c in _cardsInHand)
            {
                if (c.GetRank == rank)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
