﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7,8,9,10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var even = new List<int>();
            var odd = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);
                }
                else
                {
                    odd.Add(num);
                }

            }

            /* Now using foreach or for loops,
            * display each List of even and odd numbers
            *
            * Try to be creative in your display
            */
            foreach (var unit in even)
            {
                Console.WriteLine($"{unit} is an even number");
            }

            foreach (var unit in odd)
            {
                Console.WriteLine($"{unit} is an odd number");
            }
        }

    }
}
