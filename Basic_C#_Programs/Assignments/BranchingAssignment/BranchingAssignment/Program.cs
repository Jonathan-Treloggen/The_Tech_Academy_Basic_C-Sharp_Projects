using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            // WELCOME MESSAGE + WEIGHT QUESTION
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below." +
                "\nPlease enter the package weight in lb:");
            int packageLb = Convert.ToInt32(Console.ReadLine());

            //  ALL IF STATMENTS WILL CHECK ALL ANSWERS MAKING SURE THEIR UNDER MAX IF OVER PROGRAM WILL END
            if (packageLb > 50) 
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Haved a good day");
                Console.ReadLine();
                return;
            }
            
            // WIDTH
            Console.WriteLine("\nPlease enter the package width in inches:");
            int packageW = Convert.ToInt32(Console.ReadLine());

            if (packageW > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // HEIGHT
            Console.WriteLine("\nPlease enter the package height in inches:");
            int packageH = Convert.ToInt32(Console.ReadLine());

            if (packageH > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // LENGTH
            Console.WriteLine("\nPlease enter the package length inches:");
            int packageL = Convert.ToInt32(Console.ReadLine());
            
            if (packageL > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // TOTAL COST EQUATION

            decimal totalCost = ((packageH * packageW * packageL) * packageLb) / 100;
            

            // TOTAL SHIPPING COST
            Console.WriteLine("\nYour estimated total for shipping this package is: " + totalCost.ToString("C"));
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}
