using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // ESTABLISHING AN INT FOR MY OUT PARAMETER IN division CLASS
            int num1;

            Console.WriteLine("Enter a even number to be divided by two.");
            int input = Convert.ToInt32(Console.ReadLine());

            division div = new division();
            div.divM(input);

            Console.WriteLine("\nI love dividing numbers by two.");

            // OVERLOADED METHOD BEFORE STATIC WAS ADDED TO CLASS
            //div.divM(out num1);

            division.divM(out num1);

            Console.ReadLine();
        }
    }
}
