using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you age?");
            string age = Console.ReadLine();
            byte personsAge = Convert.ToByte(age);


            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string DUI = Console.ReadLine();
            bool anyDUIs = Convert.ToBoolean(DUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            byte numberOfTickets = Convert.ToByte(tickets);

            Console.WriteLine("\nAre you Qualified?");
            bool qualified = (personsAge > 15 && anyDUIs == false && numberOfTickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
