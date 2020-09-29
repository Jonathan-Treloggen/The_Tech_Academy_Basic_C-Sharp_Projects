using System;
using System.Collections.Generic;
using System.Linq;
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

            sThing.printAll();
            iThing.printAll();
            Console.ReadLine();
        }
    }
}
