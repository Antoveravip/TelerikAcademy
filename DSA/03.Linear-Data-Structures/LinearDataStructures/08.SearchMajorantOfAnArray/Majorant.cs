/* Lesson 3 - Linear Data Structures
 * Homework 8*
 * 
 * * The majorant of an array of size N is a value that occurs in
 * it at least N/2 + 1 times. Write a program to find the majorant
 * of given array (if exists). 
 * Example:
 * {2, 2, 3, 3, 2, 3, 4, 3, 3} --> 3
 */

namespace _08.SearchMajorantOfAnArray
{
    using System;
    using System.Collections.Generic;

    public static class Majorant
    {
        public static Dictionary<int, int> Find(int[] numbers)
        {
            Array.Sort(numbers);
            Dictionary<int, int> allNumbers = new Dictionary<int, int>();
            Dictionary<int, int> majorants = new Dictionary<int, int>();
            int majorant = numbers.Length / 2 + 1;

            foreach (var number in numbers)
            {
                if (allNumbers.ContainsKey(number))
                {
                    allNumbers[number]++;
                }
                else
                {
                    allNumbers.Add(number, 1);
                }
            }

            foreach (KeyValuePair<int, int> data in allNumbers)
            {
                if (data.Value >= majorant)
                {
                    majorants.Add(data.Key, data.Value);
                }
            }

            return majorants;
        }

        public static void Print(Dictionary<int, int> majorants)
        {
            if (majorants.Count == 0)
            {
                Console.WriteLine("No majorant found!");
            }
            else
            {
                foreach (var number in majorants)
                {
                    Console.WriteLine("One majorant is {0} -> {1} times", number.Key, number.Value);
                }
            }
        }
    }
}