using System;
using System.Collections.Generic;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace ClassesAndObjects21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to {0}. Let's start by telling me your name.", casinoName);
            string playersName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.WriteLine("And how much money did you bring with you today");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, with no decimals.");
            }
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playersName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "ya" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playersName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\jonat\OneDrive\Desktop\Repository's\The_Tech_Academy_Basic_C-Sharp_Projects\Basic_C#_Programs\Assignments\ClassesAndObjects21Game\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;
                while (player.isActivePlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact you System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }       
    }
}
