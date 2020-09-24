using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class division
    {
        public void divM(int number1, out int number2)
        {
            // GIVING number2 A VALUE TO BE USED IN THE MAIN PROGRAM
            number2 = 2;
            int number3 = number1 / number2;
            Console.WriteLine(number3);
        }
            
        public static void  divM( out int number1, out int number2 )
        {
            number1 = 144;
            number2 = 2;
            int number3 = number1 / number2;
            Console.WriteLine("\nI personaly like dividing {0} by {1} because it eaqual my favorite number {2}.", number1, number2, number3);
        }
    }
}
