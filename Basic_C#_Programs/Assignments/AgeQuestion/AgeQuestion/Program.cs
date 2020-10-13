using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Question theQ = new Question();
            try
            {
                theQ.askQuestion();   
            }
            catch (ReallyException)
            {
                Console.WriteLine("Really? Your not less than 1 year old.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred, please contact the System Administrator.");
                return;
            }
            Console.ReadLine();
        }
    }
}
