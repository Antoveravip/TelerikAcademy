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

    public static class IOSequence
    {
        public static void Main()
        {
            // Test data
            int[] numbers = new int[9] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            // Console input
            /*         
            int[] numbers;
            int length = 0;
            int number;
            string inputData = string.Empty;
            bool isNumber = false;

            Console.Write("Type how many numbers you want to enter: ");

            while (true)
            {
                inputData = Console.ReadLine();
                isNumber = int.TryParse(inputData, out number);
                bool isPositiveNumber = number >= 0;

                if (isNumber && isPositiveNumber)
                {
                    length = int.Parse(inputData);
                    break;
                }
                else
                {
                    Console.WriteLine("Not correct positive number! Type again!");
                }
            }

            numbers = new int[length];

            Console.WriteLine("Enter {0} integer numbers (in range [0-1000] )- each to a single line.", length);

            for (int i = 0; i < length;)
            {
                inputData = Console.ReadLine();
                isNumber = int.TryParse(inputData, out number);

                if (isNumber)
                {
                    number = int.Parse(inputData);
                    bool isInRange = 0 <= number && number <= 1000;
                    if (isInRange)
                    {
                        numbers[i] = number;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("The number is out of given range!");
                    }
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }                
            }
            */
           
            Dictionary<int, int> occurences = Occurence.Find(numbers);

            Occurence.Print(occurences);
        }
    }
}