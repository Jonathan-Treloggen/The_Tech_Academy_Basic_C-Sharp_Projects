using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects21Game
{
    public class Deck
    {
        // CONSTRUCTORS ALLWAYS GO AT THE TOP OF THE CLASS
        // CONSTRUCTORS ASSIGN THE PROPERTY VALUES TO OBJECTS UPON CREATION
        public Deck()
        {
            // MAKES AN EMPTY LIST WE WILL BE STORING CARDS FROM LOOP
            Cards = new List<Card>();

            // LOOPING THROUGH BOTH Face AND Suit TO MAKE A DECK OF CARDS
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    // j AND i ARE REPERSENTING THE INDEX OR PLACMENT WITHIN THE enums VALUE IN Cards HENCE THE Card LIST REFERENCE
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }

        // A DATA TYPE LIST OF CARDS THIS IS THE PROPERTY
        public List<Card> Cards { get; set; }

        // THIS IS A METHOD TO BE CALLED TO RANDOMIZE THE CARD ORDER AND TIMES IS OPTIONAL PERAMITER WITH A DEFAULT OF 1
        public void Shuffle(int times = 2)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    // FIRST NUMBER IN THE () IS MIN NUMBER THEN , TO HIGHEST NUMBER
                    int randomIndex = random.Next(0, Cards.Count);
                    // ADDING A RANDOM CARD FROM Cards from 0-max amount of cards
                    TempList.Add(Cards[randomIndex]);
                    // REMOVES THE RANDOM chosen card FROM Cards LIST
                    Cards.RemoveAt(randomIndex);
                }
                // NOW TempList = Cards SHUFFLED INTO A RANDOME ORDER WITH THIS Shuffle METHOD
                this.Cards = TempList;
            }
        }
    }
}
