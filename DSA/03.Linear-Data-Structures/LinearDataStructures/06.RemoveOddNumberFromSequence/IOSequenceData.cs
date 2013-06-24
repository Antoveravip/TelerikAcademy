/* Lesson 3 - Linear Data Structures
 * Homework 6
 * 
 * Write a program that removes from given sequence all 
 * numbers that occur odd number of times. 
 * Example:
 * {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} --> {5, 3, 3, 5}
 */

namespace _06.RemoveOddNumberFromSequence
{
    using System;
    using System.Collections.Generic;

    public static class IOSequenceData
    {
        public static void Main()
        {
            // Test data -  Declare and initialize the LinkedList data
            int[] data = { 1, -3, 8, -9, 7, -2, 2, -2, 3, -3, 5, -4, -5 };
            LinkedList<int> numbers = new LinkedList<int>(data);

            // Add data from console
            /*
            LinkedList<int> numbers = new LinkedList<int> ();
            int number;
            string inputData = string.Empty;

            Console.WriteLine("Enter an integer numbers - each to a single line. To stop entering - put empty line!");

            while (true)
            {
                inputData = Console.ReadLine();

                if (inputData == Environment.NewLine || inputData == string.Empty)
                {
                    if (numbers.Count == 0)
                    {
                        throw new ArgumentNullException("No one number was input!");
                    }
                    break;
                }

                bool isNumber = int.TryParse(inputData, out number);

                if (isNumber)
                {
                    number = int.Parse(inputData);
                    numbers.AddLast(number);
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }
            }            
            */
            LinkedList<int> positiveNumbers = Sequence.RemoveOddNumbers(numbers);

            Console.Write("Even only sequence is:");

            if (positiveNumbers.Count == 0)
            {
                Console.Write("Empty! No even numbers left!" + '\n');
            }
            else
            {
                foreach (int value in numbers)
                {
                    Console.Write(" {0},", value);
                }

                Console.Write('\b' + " " + '\n');
            }
        }
    }
}