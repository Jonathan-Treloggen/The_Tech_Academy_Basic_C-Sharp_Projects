using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st TASK
            Console.WriteLine("Type in a number and it will be times by 50 after you hit enter.");
            string givenNumber = Console.ReadLine();
            uint convNumber;
            convNumber = Convert.ToUInt32(givenNumber);
            int stayNumber = 50;
            Console.WriteLine(convNumber * stayNumber);
            

            // 2nd TASK
            Console.WriteLine("\nNow add any number you'd like to 25.");
            string givenNumber1 = Console.ReadLine();
            uint convNumber1 = Convert.ToUInt32(givenNumber1);
            int stayNumber1 = 25;
            Console.WriteLine(convNumber1 + stayNumber1);
           

            // 3rd TASK
            Console.WriteLine("\nWhatever you'd like divided by twelve point five.");
            string givenNumber2 = Console.ReadLine();
            decimal convNumber2 = Convert.ToDecimal(givenNumber2);
            decimal stayNumber2 = 12.5m;
            Console.WriteLine(convNumber2 / stayNumber2);
            

            // 4th TASK
            Console.WriteLine("\nIs what you now enter greater than 50?");
            string givennumber3 = Console.ReadLine();
            uint isit = Convert.ToUInt32(givennumber3);
            uint staynumber = 50;
            bool answer = isit > staynumber;
            Console.WriteLine(answer);
            

            // 5th TASK
            Console.WriteLine("\nWhat will your remainder be after dividing whatever number you want by seven?");
            string givenNumber4 = Console.ReadLine();
            uint convNumber4 = Convert.ToUInt32(givenNumber4);
            uint stayNumber4 = 7;
            Console.WriteLine(convNumber4 % stayNumber4);
            Console.ReadLine();
        }
    }
}
