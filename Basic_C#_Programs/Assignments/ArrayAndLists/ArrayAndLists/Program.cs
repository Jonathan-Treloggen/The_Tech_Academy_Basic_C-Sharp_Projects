using System;
using System.Collections.Generic;

namespace ArrayAndLists
{
    class Program
    {
        static void Main()
        {
            // ARRAY WITH A STRING
            Console.WriteLine("Pick a number from 0-3, this will be an idex in an array.");

            string[] stringNum = { "3", "89", "33", "92" };
            int Snum = Convert.ToInt32(Console.ReadLine());

            if (Snum <= 3)
            {
                Console.WriteLine(stringNum[Snum]);
            }
            else
            {
                Console.WriteLine("\nThe number that was entered was either too high of a number or typed out, let's try a different question.");
            }


            // ARRAY WITH INTEGERS
            Console.WriteLine("\n\nSelect a number from 0-4.");

            int[] numbers = { 44, 88, 72, 77, 64 };
            int guessedNum = Convert.ToInt32(Console.ReadLine());

            if (guessedNum <= 4)
            {
                Console.WriteLine(numbers[guessedNum]);
            }
            else
            {
                Console.WriteLine("\nWow, um you really don't know what I'm asking hugh. how about this one?");
            }


            // STRING LIST
            Console.WriteLine("\n\nLast one, pick a number from 0 or 1.");

            List<string> zeroOrOne = new List<string>();
            zeroOrOne.Add("You chose 0 very nice! And that's the end.");
            zeroOrOne.Add("You chose 1, I would have to. And that's the end");

            int stringGuess = Convert.ToInt32(Console.ReadLine());

            if (stringGuess <= 1)
            {
                Console.WriteLine(zeroOrOne[stringGuess]);
            }    
            else
            {
                Console.WriteLine("\nWell game over if you can even call this a game.");
            }
            Console.ReadLine();
        }
    }
}
