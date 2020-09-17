using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScore = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScore.Length; i++)
            //{
            //    if (testScore[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScore[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jon", "Megan", "Cody", "Spencer" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScore = new List<int>();
            //testScore.Add(98);
            //testScore.Add(99);
            //testScore.Add(81);
            //testScore.Add(72);
            //testScore.Add(70);

            //foreach (int score in testScore)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jon", "Megan", "Cody", "Spencer" };

            //foreach (string name in names)
            //{
            //    if (name == "Jon")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScore = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScore)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
