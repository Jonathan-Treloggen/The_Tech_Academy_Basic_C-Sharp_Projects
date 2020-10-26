using System;
using System.Collections.Generic;
using Casino;
using Casino.TwentyOne;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace ClassesAndObjects21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to {0}. Let's start by telling me your name.", casinoName);
            string playersName = Console.ReadLine();
            if (playersName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
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
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact you System Administrator.");
                        UpdateDbWithException(ex);
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
        
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionStirng = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                       Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                       TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                       MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                 (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionStirng))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);

                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionStirng = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                       Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                       TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                       MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionStirng))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
