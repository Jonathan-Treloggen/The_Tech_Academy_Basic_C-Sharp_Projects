using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompOperAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            // FIRST PERSON
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Type the first persons name below.\n");
            string person1 = Console.ReadLine();

            Console.WriteLine("\nHourly Rate?");
            string person1HR = Console.ReadLine();
            decimal per1HR = Convert.ToDecimal(person1HR);

            Console.WriteLine("\nHours worked per week?");
            string person1HoursPW = Console.ReadLine();
            decimal per1HPW = Convert.ToDecimal(person1HoursPW);


            // SECOND PERSON
            Console.WriteLine("\n\nEnter second persons name below.\n");
            string person2 = Console.ReadLine();

            Console.WriteLine("\nHourly Rate?");
            string person2HR = Console.ReadLine();
            decimal per2HR = Convert.ToDecimal(person2HR);

            Console.WriteLine("\nHours worked per week?");
            string person2HoursPW = Console.ReadLine();
            decimal per2HPW = Convert.ToDecimal(person2HoursPW);


            // ANNUAL SALARY OF PERSON 1
            Console.WriteLine("\n" + person1 + "'s Annual salary is:\n");
            decimal per1Annual = ((52 * per1HPW) * per1HR);
            Console.WriteLine(per1Annual);
            


            // ANNUAL SALARY OF PERSON 2
            Console.WriteLine("\n" + person2 + "'s Annual salary is:\n");
            decimal per2Annual = ((52 * per2HPW) * per2HR);
            Console.WriteLine(per2Annual);
            

            // BOOLEAN
            Console.WriteLine("\nDoes " + person1 + " make more money than " + person2 + "?");
            bool compareA = per1Annual > per2Annual;
            Console.WriteLine(compareA);
            Console.ReadLine();
        }
    }
}
