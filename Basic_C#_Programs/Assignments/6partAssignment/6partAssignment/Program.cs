using System;
using System.Collections.Generic;
using System.Globalization;

namespace _6partAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE
            // ARRAY
            string[] names = { "Jon", "Megan", "Cody", "Specer" };

            Console.WriteLine("What is you dream job?");

            // PERSON ENTERS NAME
            string dreamJob = Console.ReadLine();

            // LIST OUT ALL THE NAMES IN ARRAY
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("\n" + names[i] + "'s a " + dreamJob + ".");
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

            // FIXED LOOP + PART 3
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

            foreach (string name in console)
            {
                if (name == choice)
                {
                    Console.WriteLine("\nI love playing games on the " + name + " as well!");
                }
                else
                {
                    Console.WriteLine("What you typed was either not on the list or was not typed correctly");
                    break;
                }
            }
            Console.ReadLine();

            // PART 5
            List<string> food = new List<string>() { "PB&J", "Grilled cheese", "Trukey", "PB&J" };
            Console.WriteLine("Which of these sandwiches do you like the most? " + food[0] + ", " + food[1] + ", " + food[2] + " or " + food[3]);
            string bestSandwich = Console.ReadLine();

            foreach (string sandwich in food)
            {
                if (sandwich == bestSandwich)
                {
                    Console.WriteLine("Thats one of my favorite sandwich.");
                }
                else
                {
                    Console.WriteLine("Come on... please follow the rules.");
                    break;
                }
            }
            Console.ReadLine();

            // PART 6
            List<string> favDrinks = new List<string>() { "OJ", "Water", "Milk", "Eggnog", "Water" };

            foreach (string drink in favDrinks)
            {
                Console.WriteLine("I love " + drink);
            }
            Console.WriteLine("\nAnd yes, Water is on their twice because it's important.");
            Console.ReadLine();
        }
    }
}
