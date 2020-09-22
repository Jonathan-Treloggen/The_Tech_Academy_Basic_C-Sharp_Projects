using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            twoInt optionPer = new twoInt();
            
            

            Console.WriteLine("Enter in a number.");
            int firstNum = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Now enter a second number if you'd like if not hit enter.");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int answer = twoInt.optionalMethods(firstNum, secondNum);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
