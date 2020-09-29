using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number;
            number.Amount = 35.5M;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount;
        }
    }
}
