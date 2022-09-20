using System;

namespace ArraysAndLists
{
    using System.Collections.Generic;

    class Program
    {
        
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var firstTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            
            var evens = new List<int>();
            var odds = new List<int>();



            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */


            foreach (int i in firstTen)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");
                    evens.Add(i);
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");
                    odds.Add(i);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */


            Console.WriteLine("The following numbers make up the evens List:");
            foreach (int i in evens)
                {
                Console.Write(i + "\t");
                }

            Console.WriteLine("");

            Console.WriteLine("The following numbers make up the odds List:");
            foreach (int i in odds)
                {
                Console.Write(i + "\t");
                }



        }
    }
}
