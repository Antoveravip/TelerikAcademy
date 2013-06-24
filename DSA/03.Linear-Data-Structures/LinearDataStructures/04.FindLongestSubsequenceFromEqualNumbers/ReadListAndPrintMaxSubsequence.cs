/* Lesson 3 - Linear Data Structures
 * Homework 4
 * 
 * Write a method that finds the longest subsequence of equal numbers 
 * in given List<int> and returns the result as new List<int>.
 * Write a program to test whether the method works correctly.
 */

namespace _04.FindLongestSubsequenceFromEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public static class ReadListAndPrintMaxSubsequence
    {
        public static void Main()
        {
            // Test List data -  Declare and initialize the List data
            // List<int> numbers = new List<int>() { 1, 1, 8, 9, 7, 2, 2, 2, 3, 3, 5, 4, 8 };

            // Add data from console
            List<int> numbers = new List<int>();
            int number;
            string inputData = string.Empty;

            Console.WriteLine("Enter an integer numbers - each to a single line. To stop entering - put empty line!");

            while (true)
            {
                inputData = Console.ReadLine();

                if (inputData == Environment.NewLine || inputData == string.Empty)
                {
                    break;
                }

                bool isNumber = int.TryParse(inputData, out number);

                if (isNumber)
                {
                    number = int.Parse(inputData);
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }
            }

            List<int> longestSubsequence = new List<int>();

            longestSubsequence = ListFind.LongestSubsequence(numbers);

            // Print the result
            int seqLength = longestSubsequence.Count;
            Console.Write("The longest subsequence is:");

            for (int i = 0; i < seqLength; i++)
            {
                Console.Write(" {0},", longestSubsequence[i]);
            }

            Console.Write('\b' + " " + '\n');
        }
    }
}