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

    public static class StackExtensions
    {
        public static bool IsListNullOrEmpty(Stack<int> numbers)
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

        public static Stack<int> Reverse(Stack<int> numbers)
        {
            Stack<int> reversed = new Stack<int>();
            bool isListNullOrEmpty = IsListNullOrEmpty(numbers);

            // Here we can throw an ArgumentNullException, or return an empty stack, and message that Stack is null or empty!
            if (isListNullOrEmpty)
            {
                // throw new ArgumentNullException("This Stack is empty!");
                Console.WriteLine("Error: This Stack<int> data is null or empty!");
            }
            else
            {
                while (numbers.Count > 0)
                {
                    reversed.Push(numbers.Pop());
                }
            }

            return reversed;
        }
    }
}