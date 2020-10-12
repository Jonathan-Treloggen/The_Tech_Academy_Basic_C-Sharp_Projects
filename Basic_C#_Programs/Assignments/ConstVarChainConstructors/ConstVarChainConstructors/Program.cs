using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string assignment = "Hello, it's me.";
            var not = new Class1(72);

            Console.WriteLine("{0} No, it's the number {1}, come on {2}...", assignment, not.bestNum, not.bestName);
            Console.ReadLine();
        }
    }
}
