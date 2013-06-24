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

    public static class FindMajorant
    {
        public static void Main()
        {
            // Test data
            int[] numbers = new int[12] { 2, 3, 3, 3, 2, 3, 2, 3, 3, 2, 2, 3 };

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

            Console.WriteLine("Enter {0} integer numbers - each to a single line.", length);

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
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }                
            }
            */

            Dictionary<int, int> majorants = Majorant.Find(numbers);

            Majorant.Print(majorants);
        }
    }
}