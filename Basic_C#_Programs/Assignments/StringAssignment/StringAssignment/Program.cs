using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            string name = "Jon";
            string name2 = "Megan";
            string name3 = "Megan G.";

            // UPPERCASE
            name = name.ToUpper();

            // CONCATENATES
            Console.WriteLine(name + " and " + name2 + ", are friends with " + name3 + ".");

            // STRINGBUILDER
            StringBuilder sb = new StringBuilder();
            sb.Append("\nMy name is Jon. ");
            sb.Append("I've been programming for only three months. ");
            sb.Append("I'm having a lot of fun coding, figuring out how it all works and actually getting it.");
            sb.Append("This boot camp, in my opinion was completely worth it.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
