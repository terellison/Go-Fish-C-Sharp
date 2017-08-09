using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish
{
    class MainGoFish
    {
        static void Main(string[] args)
        {
            Card[] deck = new Card[52];
            int suit = 0;
            int rank = 0;
            int d = 0;
            while (d < 52)
            {
                while (suit < 4)
                {
                    while (rank < 13)
                    {
                        deck[d] = new Card(suit, rank);
                        d++;
                        rank++;
                    }
                    rank = 0;
                    suit++;
                }
            }







            Console.ReadKey();
        }
    }
}
