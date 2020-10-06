using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's " + DateTime.Now + "\nPlease enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + input + "hrs it will be\n" + DateTime.Now.AddHours(input));
            Console.ReadLine();
        }
    }
}
