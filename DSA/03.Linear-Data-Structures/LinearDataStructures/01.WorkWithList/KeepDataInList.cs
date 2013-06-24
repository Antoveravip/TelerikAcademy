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

    public class KeepDataInList
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            int number;
            string inputData = string.Empty;

            // We can calculate the sum of elements simply by their input, or do later working with List data.
            // For purpose of this homework - I commented these lines with simplified decision and work with List data. 
            long sum = 0;
            long average = 0;

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
                    bool isPositiveNumber = number >= 0;

                    if (isPositiveNumber)
                    {
                        // sum += number;
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Not positive number! Input another number:");
                    }
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }
            }

            // average = sum / numbers.Count;
            sum = ListFind.Sum(numbers);
            average = ListFind.Average(numbers);

            Console.WriteLine("The sum of the numbers in this list is {0}", sum);
            Console.WriteLine("The average value of the numbers is {0}", average);
        }
    }
}