using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // == IF, ELSE IF AND ELSE 
            Console.WriteLine("What's Brock's primary Pokemon in the first season of Pokemon? " +
                "\n(Hint it starts whith O and ends with X.)");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "Onix")
            {
                Console.WriteLine("Correct! Next question.");
            }

            else if (userAnswer == "onix")
            {
                Console.WriteLine("Correct! Next question.");
            }

            else
            {
                Console.WriteLine("Wrong! Next question.");
            }


            // != 
            string name = "Jon the programmer of this code";

            if (name != "bob")
            {
                Console.WriteLine("\nYour not Jon, who are you?");
            }

            else
            {
                Console.WriteLine("Jon is the programmer.");
            }
            string personsName =Console.ReadLine();
            Console.WriteLine("\nOk " + personsName + ", I have some more questions to ask you, but only I can answer (evil laughter goes here)." +
                "\nIs 48 < 66 lets find out.");


            //  > or < 
            int num1 = 48;
            int num2 = 66;
            if (num1 < num2)
            {
                Console.WriteLine("\nCorrect " + num1 + " is less then " + num2 +".");
            }

            // CAN BE TYPED EITHER WAY

            else
            {
                Console.WriteLine("\nWrong 48 is not greater then 66.");
            }
            

            // >= or <=
            Console.WriteLine("\nIs the programmer Jon, old enough to drink alcohol? (Hit the enter button to find out.)");
            Console.ReadLine();
            int age = 27;
            if (age >= 21)
            {
                Console.WriteLine("Why, yes, yes he is.");         
            }

            else
            {
                Console.WriteLine("well either way I'm still old enough so ya.");
            }
            Console.ReadLine();

            // && SIMBLE FOR AND
            // || SIMBLE FOR OR

            // ? : IS A SIMPLE AND FASTER VERSION OF IF, ELSE
            int num3 = 43;
            int num4 = 72;

            string result = num3 > num4 ? "Wow some how 43 is greater than 72, what weird times." : "43 is not greater than 72.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
