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

    public class NumberOccurence
    {
        public static void Main()
        {
            // Test data
            double[] numbers = new double[9] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            // Console input
            /*
            double[] numbers;
            int length = 0;
            double number;
            string inputData = string.Empty;
            bool isNumber = false;

            Console.Write("Type how many numbers you want to enter: ");

            while (true)
            {
                inputData = Console.ReadLine();
                isNumber = double.TryParse(inputData, out number);
                bool isPositiveNumber = length >= 0;

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

            numbers = new double[length];

            Console.WriteLine("Enter {0} integer numbers - each to a single line.", length);

            for (int i = 0; i < length;)
            {
                inputData = Console.ReadLine();
                isNumber = double.TryParse(inputData, out number);

                if (isNumber)
                {
                    number = double.Parse(inputData);
                        numbers[i] = number;
                        i++;
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }                
            }
            */

            Dictionary<double, int> occurences = Occurence.Find(numbers);

            Occurence.Print(occurences);
        }
    }
}