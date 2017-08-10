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
        private List<Card> _cardsInHand = new List<Card>();
        int _books = 0;

        public Player(string name)
        {
            _name = name;
        }

        public void DrawCard(Card[] deck)
        {
            Random randCard = new Random();     //Takes random card object and adds it to '_cardsInHand' List.
            int drawCard = randCard.Next(deck.Length + 1);
            _cardsInHand.Add(deck[drawCard]);

            List<Card> deckList = deck.ToList();   //Converts deck into List and removes the same card object; converts back to Array.
            deckList.RemoveAt(drawCard);
            deckList.ToArray();
        }

        public void Draw9Cards(Card[] deck)     //Draws 9 cards to start game.
        {
            int x = 0;
            while(x < 9)
            {
                DrawCard(deck);
                x++;
            }
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

        public List<Card> GetCardsInHand { get { return _cardsInHand; } }
    }

}
