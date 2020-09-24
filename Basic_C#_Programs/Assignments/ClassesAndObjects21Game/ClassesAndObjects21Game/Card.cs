using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects21Game
{
     // A CLASS IS A DESIGN FOR AN OBJECT
    // DON'T FORGET TO MAKE YOUR CLASS PUBLIC
    public class Card
    {
        // CONSTRUCTOR A VALUE ASSIGNED TO AN OBJECT UPON CREATION.
        // CONSTRUCTOR METHOD NAME IS ALLWAYS THE NAME OF THE CLASS
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        // PUBLIC MAKES IT AVAILABLE TO THE REST OF THE PROGRAM
        // ONLY TWO THINGS YOU CAN DO WITH AN OBJECT PROPERTY IS GET AND SET
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
