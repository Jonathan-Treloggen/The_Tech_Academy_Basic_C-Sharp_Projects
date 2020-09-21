using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class mathOperations
    {
        public static int addNumbers()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a second number.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int answer = number1 + number2;
            return answer;
        }

        public static decimal multiNumbers()
        {
            Console.WriteLine("\nNow its time to multiply two number together. Enter your first one now.");
            decimal number3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter your second number.");
            decimal number4 = Convert.ToDecimal(Console.ReadLine());
            int answer2 = Convert.ToInt32(number3) * Convert.ToInt32(number4);
            return answer2;
        }

        public static int minusNumber()
        {
            Console.WriteLine("\nLast but not least put in your first of two numbers to subtract each other.");
            string number5 = Console.ReadLine();
            Console.WriteLine("Enter your second number.");
            string number6 = Console.ReadLine();
            int answer3 = Convert.ToInt32(number5) - Convert.ToInt32(number6);
            return answer3;
        }
            
    }
}
