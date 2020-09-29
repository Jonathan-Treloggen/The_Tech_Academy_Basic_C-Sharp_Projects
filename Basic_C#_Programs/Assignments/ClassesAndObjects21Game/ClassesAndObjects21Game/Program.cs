using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATA TYPE DECK WITH VARIABLE NAMED deck THIS ALSO INSTANTIATES THE OBJECT
            Deck deck = new Deck(); 
            deck.Shuffle(8);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }       
    }
}
