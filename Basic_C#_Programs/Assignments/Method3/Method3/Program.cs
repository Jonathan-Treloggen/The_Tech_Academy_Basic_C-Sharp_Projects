using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMethod voidMethod = new voidMethod();

            Console.WriteLine("Enter a number of you choice to be added to 12 and see if you can" +
                "\nguess the correct number. (hint it's under 100)");
            int guestNumber = Convert.ToInt32(Console.ReadLine());

            voidMethod.vMethod(guestNumber);
            Console.ReadLine();
        }
    }
}
