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

            // MAKES LIST WITH VALUES
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack",
                "Queen", "King", "Ace"
            };

            // NEW VARIABLE ASSIGNED IN Faces LIST ABOVE
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    // MAKEING NEW INDIVIDUAL card EACH LOOP ALSO IS REFERENCED IN THE MAIN PROGRAM FOREACH LOOP
                    Card card = new Card();

                    // NEW INDIVIDUAL card LIST REFERENCES THE LIST ABOVE Suits & Faces WITCH IS NOW EQUAL TO VARIABLE suits & faces CREATED IN THE FOREACH LOOP
                    card.Suit = suit;
                    card.Face = face;

                    // ADDS CARD TO Cards list
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
