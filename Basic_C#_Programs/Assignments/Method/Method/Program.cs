using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first of two number to be added together.");
            int numberProblem = mathOperations.addNumbers();

            Console.WriteLine("Both of your numbers added together equals: {0}", numberProblem);

            int numberProblem2 = (int)mathOperations.multiNumbers();
            Console.WriteLine("Both of your numbers multiplyed together equals: {0}", numberProblem2);

            int numberProblem3 = mathOperations.minusNumber();
            Console.WriteLine("Both of your numbers subtracted from each other equals: {0}", numberProblem3);
            Console.ReadLine();
        }
    }
}
