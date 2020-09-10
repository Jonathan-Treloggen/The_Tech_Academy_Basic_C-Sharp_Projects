using System;


namespace DR
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTRODUCTION LINE
            Console.WriteLine("The Tech Academy \nStudent Daily Report.");
            Console.WriteLine("\n\tPress the enter button after typing your answer and to move on tho the next question.");

            // QUESTIONS
            Console.WriteLine("\nWhats your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("\tHello " + yourName + ".");
            Console.ReadLine();


            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            

            Console.WriteLine("\nWhat page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

          
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string answer = Console.ReadLine();
          
            
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string help = Console.ReadLine();

          
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudying = Console.ReadLine();
            int hoursStu = Convert.ToInt32(hoursStudying);


            Console.WriteLine("\nThank you for answers. An Instructor will respond to this shortly. Have a great day");
            Console.ReadLine();

        }
    }
}
