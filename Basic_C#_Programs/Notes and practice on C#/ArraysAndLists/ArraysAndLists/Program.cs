using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            // LIST
            // LIST CAN USE ANY DATA TYPE
            List<int> intList = new List<int>();

            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();


        // ARRAY WHICH YOU CAN NOT CHANGE THE SIZE OF THE ARRAY ONCE SET

        // STORING PICTURES
            //byte[] byteArray = new byte[];

        // SLOW WAY
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

        // FASTER WAY
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        // EVEN FASTER WAY
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        // YOU CAN CHANGE A VALUE IN AN ARRAY
            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }
}
