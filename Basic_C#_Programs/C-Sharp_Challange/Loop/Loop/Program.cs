using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 72;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 33:
                        Console.WriteLine("You guessed 33. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 44:
                        Console.WriteLine("You guessed 44. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 72:
                        Console.WriteLine("You guessed 72. That is correct.");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
