/* Lesson 3 - Linear Data Structures
 * Homework 4
 * 
 * Write a method that finds the longest subsequence of equal numbers 
 * in given List<int> and returns the result as new List<int>.
 * Write a program to test whether the method works correctly.
 */

namespace _04.FindLongestSubsequenceFromEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public static class ListFind
    {
        public static bool IsListNullOrEmpty(List<int> numbers)
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

        public static List<int> LongestSubsequence(List<int> numbers)
        {
            bool isListNullOrEmpty = IsListNullOrEmpty(numbers);

            if (isListNullOrEmpty)
            {
                throw new ArgumentNullException("This List is null or empty!");
            }

            int numLength = numbers.Count;
            int length = 0;
            int maxLength = 0;
            int index = 0;
            int maxIndex = 0;

            for (int i = 0; i < numLength; i++)
            {
                if (i == 0)
                {
                    length = 1;
                    maxLength = 1;
                    index = i;
                }
                else
                {
                    bool areEqual = numbers[i] == numbers[i - 1];
                    if (!areEqual)
                    {
                        length = 1;
                        index = i;
                    }
                    else if (areEqual)
                    {
                        length++;
                        if (length > maxLength)
                        {
                            maxIndex = index;
                            maxLength = length;
                        }
                    }
                }
            }

            List<int> longestSubsequence = new List<int>();
            int longestLengt = maxIndex + maxLength;

            for (int i = maxIndex; i < longestLengt; i++)
            {
                longestSubsequence.Add(numbers[i]);
            }

            return longestSubsequence;
        }
    }
}