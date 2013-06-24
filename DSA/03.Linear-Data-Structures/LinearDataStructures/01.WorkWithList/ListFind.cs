/* Lesson 3 - Linear Data Structures
 * Homework 1
 * 
 * Write a program that reads from the console a sequence of positive integer numbers. 
 * The sequence ends when empty line is entered. Calculate and print the sum and average 
 * of the elements of the sequence. Keep the sequence in List<int>.
 */

// Name of namespace is not good - but I leave it that for better guidance in the tasks! 
namespace _01.WorkWithList
{
    using System;
    using System.Collections.Generic;

    public static class ListFind
    {
        public static bool IsListNullOrEmpty(List<int> numbers)
        {
            bool isListNullOrEmpty = true;

            if (numbers == null || numbers.Count == 0)
            {
                isListNullOrEmpty = true;
            }
            else
            {
                isListNullOrEmpty = false;
            }

            return isListNullOrEmpty;
        }

        public static long Sum(List<int> numbers)
        {
            long sum = 0;
            int listCount = 0;
            bool isListNullOrEmpty = IsListNullOrEmpty(numbers);

            // Here we can throw an ArgumentNullException, or return sum = zero, and message that List is null or empty!
            if (isListNullOrEmpty)
            {
                // throw new ArgumentNullException("This List is empty!");
                Console.WriteLine("Error: This List<int> data is null or empty!");
                sum = 0;
            }
            else
            {
                listCount = numbers.Count;
                for (int i = 0; i < listCount; i++)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public static long Average(List<int> numbers)
        {
            long sum = 0;
            long average = 0;
            int listCount = 0;
            bool isListNullOrEmpty = IsListNullOrEmpty(numbers);

            // Here we can throw an ArgumentNullException, or return average = zero, and message that List is null or empty!
            if (isListNullOrEmpty)
            {
                // throw new ArgumentNullException("This List is empty!");
                Console.WriteLine("Error: This List<int> data is null or empty!");
                average = 0;
            }
            else
            {
                listCount = numbers.Count;
                sum = Sum(numbers);
                average = sum / listCount;
            }

            return average;
        }
    }
}