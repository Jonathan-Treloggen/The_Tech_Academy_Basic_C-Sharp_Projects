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
            Console.WriteLine("Enter a number.");

            int input1 = Convert.ToInt32(Console.ReadLine());
            mathOperations math = new mathOperations();
            int answer1 = math.doMath(input1);
            Console.WriteLine("Your numbers added together with five equals: {0}\n\nEnter another number.", answer1);

            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            int answer2 = math.doMath(input2);
            Console.WriteLine("Your numbers multiplyed by five equals: {0}\n\nEnter in one more number, please.", answer2);

            string input3 = Console.ReadLine();
            int answer3 = math.doMath(input3);
            Console.WriteLine("Your numbers subtracted by 5 equals: {0}", answer3);

            Console.ReadLine();
        }
    }
}
