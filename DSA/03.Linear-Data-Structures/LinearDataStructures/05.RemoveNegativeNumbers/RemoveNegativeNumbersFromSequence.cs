/* Lesson 3 - Linear Data Structures
 * Homework 5
 * 
 * Write a program that removes from given sequence all negative numbers.
 */

namespace _05.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public static class RemoveNegativeNumbersFromSequence
    {
        public static void Main()
        {
            // Test data -  Declare and initialize the LinkedList data
            int[] data = { 1, -1, 8, -9, 7, -2, 2, -2, 3, -3, 5, -4, -8 };
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
            LinkedList<int> positiveNumbers = NumbersSequence.RemoveNegative(numbers);

            Console.Write("Positive only sequence is:");

            if (positiveNumbers.Count == 0)
            {
                Console.Write("Empty! No positive numbers left!" + '\n');
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