/* Lesson 3 - Linear Data Structures
 * Homework 2
 * 
 * Write a program that reads N integers from the console and 
 * reverses them using a stack. Use the Stack<int> class.
 */

namespace _02.ReverseNumbersInStack
{
    using System;
    using System.Collections.Generic;

    public static class ReverseNumbers
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();
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

            Console.WriteLine("Enter {0} integer numbers - each to a single line.", length);

            for (int i = 0; i < length;)
            {
                inputData = Console.ReadLine();
                isNumber = int.TryParse(inputData, out number);

                if (isNumber)
                {
                    number = int.Parse(inputData);                   
                    numbers.Push(number);
                    i++;
                }
                else
                {
                    Console.WriteLine("Ivalid number format! Input only positive numbers!");
                }                
            }

            Console.WriteLine("Result reversing with using Steck class:");
            foreach (int numValue in numbers)
            {
                Console.WriteLine(numValue);
            }

            Stack<int> reversed = new Stack<int>();
            reversed = StackExtensions.Reverse(numbers);

            Console.WriteLine("Result another reversing using the second Steck:");
            foreach (int numValue in reversed)
            {
                Console.WriteLine(numValue);
            }
        }
    }
}