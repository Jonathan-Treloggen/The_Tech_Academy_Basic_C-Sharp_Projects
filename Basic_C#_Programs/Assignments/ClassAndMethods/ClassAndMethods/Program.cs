using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number you want to add to 10.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = 10;
            int firstTotal = _3Methods.addTwoNumbers(number1, number2);
            Console.WriteLine("\nThe whole number you entered " + number1 + " + " + number2 + " = " + firstTotal);
            

            Console.WriteLine("\nNow enter a whole number to be timesed by 5.");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = 5;
            int secondTotal = _3Methods.timesTwoNumbers(number3, number4);
            Console.WriteLine("\nThe whole number you entered " + number3 + " * " + number4 + " = " + secondTotal);

            Console.WriteLine("\nNow enter a whole number to be subtracted by 8.");
            int number5 = Convert.ToInt32(Console.ReadLine());
            int number6 = 8;
            int thirdTotal = _3Methods.minusTwoNumbers(number5, number6);
            Console.WriteLine("\nThe whole number you entered " + number5 + " - " + number6 + " = " + thirdTotal);

            Console.ReadLine();
        }
    }
}
