/* Lesson 5 - Dictionaries Hash Tables And Sets
 * Homework 1
 * 
 * Write a program that counts in a given array of double values the 
 * number of occurrences of each value. Use Dictionary<TKey,TValue>.
 * Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
 * -2.5 --> 2 times
 * 3 --> 4 times
 * 4 --> 3 times
 */

namespace _01.CountsNumberOccurence
{
    using System;
    using System.Collections.Generic;

    public static class Occurence
    {
        public static Dictionary<double, int> Find(double[] numbers)
        {
            Array.Sort(numbers);
            Dictionary<double, int> occurences = new Dictionary<double, int>();

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

        public static void Print(Dictionary<double, int> occurences)
        {
            foreach (var number in occurences)
            {
                Console.WriteLine("{0} -> {1} times", number.Key, number.Value);
            }
        }
    }
}