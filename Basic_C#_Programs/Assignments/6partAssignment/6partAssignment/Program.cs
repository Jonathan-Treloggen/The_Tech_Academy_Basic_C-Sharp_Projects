using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace _6partAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE
            // ARRAY
            string[] names = { "jon", "megan", "cody", "specer" };

            Console.WriteLine("what is you dream job?");

            // PERSON ENTERS NAME
            string dreamJob = Console.ReadLine();

            // LIST OUT ALL THE NAMES IN ARRAY
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + " " + dreamJob;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("\n" + names[i] + ".");
            }

            Console.ReadLine();

            // PART TWO
            // WARNING INFINITE LOOP AHEAD
            //Console.WriteLine("Perpare to close out of the Console, unless you like seing all those numbers fly bye on you screen forever.");
            //Console.ReadLine();

            //for (int infinite = 0; infinite < 1; infinite--)
            //{
            //    Console.WriteLine("value : {0}", infinite);
            //}
            //Console.ReadLine();

            //// FIXED LOOP + PART 3
            for (int infiniteFixed = 0; infiniteFixed < 11; infiniteFixed++)
            {
                Console.WriteLine(infiniteFixed);
            }
            Console.ReadLine();

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();

            // PART 4
            List<string> console = new List<string>() { "Xbox", "Playstation", "Switch", "PC/Mac" };
            Console.WriteLine("Which console do you prefer " + console[0] + ", " + console[1] + ", " + console[2] + " or " + console[3] + "? Please type is exactly as typed please.");
            string choice = Console.ReadLine();
            bool itsHere = false;
            for (int i = 0; i < console.Count; i++)
            {
                if (console[i] == choice)
                {
                    Console.WriteLine("Index number is {0}", i);
                    itsHere = true;
                    break;
                }
            }
            if (!itsHere)
            {
                Console.WriteLine("Entery is not on list.");
            }
            Console.ReadLine();

            // PART 5
            List<string> food = new List<string>() { "PB&J", "Grilled cheese", "Trukey", "PB&J" };
            Console.WriteLine("Which of these sandwiches do you like the most? " + food[0] + ", " + food[1] + ", " + food[2] + " or " + food[3]);
            string bestSandwich = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == bestSandwich)
                {
                    Console.WriteLine("Index of your choice is {0}", i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Your choice is not on the list.");
            }
            Console.ReadLine();

            // PART 6
            List<string> favDrinks = new List<string>() { "OJ", "Water", "Milk", "Eggnog", "Water" };
            List<string> foundList = new List<string>();
            foreach (string drink in favDrinks)
            {
                if (foundList.Contains(drink) == false)
                {
                    foundList.Add(drink);
                    Console.WriteLine("{0} it's not on the list yet", drink);
                }
                else
                {
                    Console.WriteLine("{0} is already on the list", drink);
                }
            }
            Console.ReadLine();
        }
    }
}
