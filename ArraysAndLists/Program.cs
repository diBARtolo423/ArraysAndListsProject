using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */


            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                   evens.Add(numbers[i]);
                }
                
            }
            foreach (var even in evens)
            {
                Console.WriteLine($"{even} is an even number");
            }

            Console.WriteLine(" ");

            var odds = new List<int>();
            for (int i = 0; i < numbers.Length; i ++)
            {
                if (numbers[i] %2 != 0)
                { 
                    odds.Add(numbers[i]);
                }
            }
            foreach (var odd in odds)
            {
                Console.WriteLine($"{odd} is an odd number");
            }


        }
    }
}
