using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            
            try
            {
                List<int> numbers = new List<int>() { 15, 20, 64, 35 };
                int enteredNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int numberToDivide in numbers)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int total = numbers[i] / enteredNumber;
                        Console.WriteLine(numbers[i] + " divided by you number " + enteredNumber + " equals " + total);
                    }
                    break;
                }
            }
            catch (FormatException Fex)
            {
                Console.WriteLine("Please type a whole number like this: 4, not this: four.");
            }
            catch (DivideByZeroException Zex)
            {
                Console.WriteLine("\nPlease don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("the program has emerged from the try/catch block");
            Console.ReadLine();
        }
    }
}
