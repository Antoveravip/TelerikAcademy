/* Lesson 3 - Linear Data Structures
 * Homework 3
 * 
 * Write a program that reads a sequence of integers (List<int>) ending 
 * with an empty line and sorts them in an increasing order.
 */

namespace _03.SortIncreasingNumber
{
    using System;
    using System.Collections.Generic;

    public static class IncreaseSorting
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            int number;
            string inputData = string.Empty;

            Console.WriteLine("Enter a positive integer numbers - each to a single line. To stop entering - put empty line!");
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
                    Console.WriteLine("Ivalid number format! Input only integer numbers!");
                }
            }

            // Sorting using List<int> Sort method.
            numbers.Sort();
            int length = numbers.Count;

            Console.WriteLine("Sorted elements are:");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}