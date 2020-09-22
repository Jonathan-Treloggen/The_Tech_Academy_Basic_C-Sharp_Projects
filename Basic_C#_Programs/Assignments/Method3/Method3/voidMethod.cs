using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class voidMethod
    {
        public static void vMethod(int number1, int number2 = 72)
        {
            int mathProb = number1 + 12;
            Console.WriteLine("{0} is just not as good as {1}", mathProb, number2);
            Console.ReadLine();
        }
    }
}
