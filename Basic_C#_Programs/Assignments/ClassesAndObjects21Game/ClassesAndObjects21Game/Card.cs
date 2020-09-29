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
        // PUBLIC MAKES IT AVAILABLE TO THE REST OF THE PROGRAM
        // ONLY TWO THINGS YOU CAN DO WITH AN OBJECT PROPERTY IS GET AND SET
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Heart,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
