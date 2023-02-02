/*
 Author: SM ZAMAN
 Date: 02/02/2023
 Comments: This C# Console application code demostrates the use
            of arrays after getting input from users
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          


            int number = 25;
            int[] fibonacci = new int[number];

            // initialize fibonacci series
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < number; i++)
            {
                if (i >= 2)

                {

                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
            Console.ReadKey();
        }
    }

}