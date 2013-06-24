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

    public static class Sequence
    {
        public static LinkedList<int> RemoveOddNumbers(LinkedList<int> numbers)
        {
            bool isListNullOrEmpty = IsListNullOrEmpty(numbers);

            if (isListNullOrEmpty)
            {
                throw new ArgumentNullException("This sequence is empty!");
            }

            LinkedListNode<int> evenNumbers = numbers.First;

            while (evenNumbers != null)
            {
                LinkedListNode<int> nextNode = evenNumbers.Next;
                if (evenNumbers.Value % 2 != 0)
                {
                    numbers.Remove(evenNumbers);
                }

                evenNumbers = nextNode;
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