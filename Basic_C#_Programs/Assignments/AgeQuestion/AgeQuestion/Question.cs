using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeQuestion
{
    class Question
    {
        public void askQuestion()
        {
            int Age = 0;
            bool validAge = false;
            while (!validAge)
            {
                Console.WriteLine("Enter your age in years please.");
                validAge = int.TryParse(Console.ReadLine(), out Age);
                if (!validAge) Console.WriteLine("Please enter digits only, with no decimals.");
                else
                {
                    int dateOfBirth = DateTime.Now.Year - Age;
                    Console.WriteLine("So if your {0}, then you were born in {1}.", Age, dateOfBirth);
                }
            }
            if (Age <= 0)
            {
                throw new ReallyException();
            }
        }
    }
}
