using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTABLISHING AN INT FOR MY OUT PARAMETER IN division CLASS
            int divNumber2;
            int num1;
            int num2;

            Console.WriteLine("Enter a even number to be divided by two.");
            int input = Convert.ToInt32(Console.ReadLine());

            division div = new division();
            div.divM(input, out divNumber2);

            Console.WriteLine("\nI love dividing numbers by " + divNumber2);

            // OVERLOADED METHOD BEFORE STATIC WAS ADDED TO CLASS
            //div.divM(out num1, out num2);

            division.divM(out num1, out num2);

            Console.ReadLine();
        }
    }
}
