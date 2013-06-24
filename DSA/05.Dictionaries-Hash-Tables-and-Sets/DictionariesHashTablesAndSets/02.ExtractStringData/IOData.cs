/* Lesson 5 - Dictionaries Hash Tables And Sets
 * Homework 2
 * 
 * Write a program that extracts from a given sequence of strings
 * all elements that present in it odd number of times. 
 * Example: {C#, SQL, PHP, PHP, SQL, SQL } --> {C#, SQL}
 */

namespace _02.ExtractStringData
{
    using System;
    using System.Collections.Generic;

    public static class IOData
    {
        public static void Main()
        {
            // Test data
            string text = "C#, SQL, PHP, PHP, SQL, SQL";

            // Console input   
            /*
            string text = string.Empty;

            Console.Write("Type some text: ");
            text = Console.ReadLine();
            */
            IDictionary<string, int> sortedWordsCount = new SortedDictionary<string, int>();
            IDictionary<string, int> sortedWords = Data.CountWords(text, sortedWordsCount);
            Data.PrintOddOccurences(sortedWords);
        }
    }
}
