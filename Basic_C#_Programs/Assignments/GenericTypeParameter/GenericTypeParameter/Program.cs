using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeParameter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> sThing = new Employee<string>();
            sThing.things = new List<string>() { "I think I'm now finally doing this right", "At the same time I'm not sure." };

            Employee<int> iThing = new Employee<int>();
            iThing.things = new List<int>() { 72, 44 };

            foreach (string thing in sThing.things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in iThing.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
