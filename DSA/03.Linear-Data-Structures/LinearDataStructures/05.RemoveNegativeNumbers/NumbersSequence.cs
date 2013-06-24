/* Lesson 3 - Linear Data Structures
 * Homework 5
 * 
 * Write a program that removes from given sequence all negative numbers.
 */

namespace _05.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public static class NumbersSequence
    {
        public static LinkedList<int> RemoveNegative(LinkedList<int> numbers)
        {
            bool isListNullOrEmpty = IsListNullOrEmpty(numbers);

            if (isListNullOrEmpty)
            {
                throw new ArgumentNullException("This sequence is empty!");
            }

            LinkedListNode<int> negativeNumbers = numbers.First;

            while (negativeNumbers != null)
            {
                LinkedListNode<int> nextNode = negativeNumbers.Next;
                if (negativeNumbers.Value < 0)
                {
                    numbers.Remove(negativeNumbers);
                }

                negativeNumbers = nextNode;
            }

            return numbers;
        }

        public static bool IsListNullOrEmpty(LinkedList<int> numbers)
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
    }
}