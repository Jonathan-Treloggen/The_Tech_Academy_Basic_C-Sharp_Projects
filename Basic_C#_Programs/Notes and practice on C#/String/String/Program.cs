using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jon";
            string quote = "The man said, \"Hello\", Jon. \nHello on a new line. \n\tHello on a tab";
            string fileName = "C:\\User\\Jon";
            // OR DO IT THIS WAY WITH AN @ SYMBOL
            string fileName2 = @"C:\User\Jon";

            // DOES A NAME CONTAIN A SPECIFIC LETTER
            bool trueOrFalse = name.Contains("n");

            // WHAT IT ENDS WITH
            trueOrFalse = name.EndsWith("o");

            // HOW LONG A NAME IS
            int length = name.Length;

            // LOWER CASE STRING
            name = name.ToLower();

            // UPPER  CASE STRING
            name = name.ToUpper();

            // IF THIS HAPPENS YOU ARE ADDING CODE NOT REPLACING
            string name2 = "Jon";
            name2 = "Megan";

            // PERFERED WAY
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jon");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
