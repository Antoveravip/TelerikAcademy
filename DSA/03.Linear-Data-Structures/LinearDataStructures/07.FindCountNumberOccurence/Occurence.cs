/* Lesson 3 - Linear Data Structures
 * Homework 7
 * 
 * Write a program that finds in given array of integers 
 * (all belonging to the range [0..1000]) how many times
 * each of them occurs.
 * 
 * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
 * 2 --> 2 times
 * 3 --> 4 times
 * 4 --> 3 times
 */

namespace _07.FindCountNumberOccurence
{
    using System;
    using System.Collections.Generic;

    public static class Occurence
    {
        public static Dictionary<int, int> Find(int[] numbers)
        {
            Array.Sort(numbers);
            Dictionary<int, int> occurences = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (occurences.ContainsKey(number))
                {
                    occurences[number]++;
                }
                else
                {
                    occurences.Add(number, 1);
                }
            }

            return occurences;
        }

        public static void Print(Dictionary<int, int> occurences)
        {
            foreach (var number in occurences)
            {
                Console.WriteLine("{0} -> {1} times", number.Key, number.Value);
            }
        }
    }
}
