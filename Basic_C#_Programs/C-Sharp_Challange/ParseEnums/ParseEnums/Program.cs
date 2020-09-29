using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite day of the week? Please make sure to capitalize you first letter.");
            string favDayOfWeek = Console.ReadLine();

            try
            {
                daysOfTheWeek favAnswer = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), favDayOfWeek, true);
                if (Enum.IsDefined(typeof(daysOfTheWeek), favAnswer))
                    Console.WriteLine("{0} is a good choice.", favAnswer);
                else
                    Console.WriteLine("Try again.");
            }    
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
