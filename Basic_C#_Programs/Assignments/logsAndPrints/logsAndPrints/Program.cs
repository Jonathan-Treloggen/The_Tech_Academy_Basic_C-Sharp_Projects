using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logsAndPrints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string inputedNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\jonat\OneDrive\Desktop\Repository's\The_Tech_Academy_Basic_C-Sharp_Projects\Basic_C#_Programs\Assignments\logsAndPrints\logs\logs.txt", inputedNumber);
            Console.WriteLine(File.ReadAllText(@"C:\Users\jonat\OneDrive\Desktop\Repository's\The_Tech_Academy_Basic_C-Sharp_Projects\Basic_C#_Programs\Assignments\logsAndPrints\logs\logs.txt") + " good choice.");
            Console.ReadLine();
        }
    }
}
