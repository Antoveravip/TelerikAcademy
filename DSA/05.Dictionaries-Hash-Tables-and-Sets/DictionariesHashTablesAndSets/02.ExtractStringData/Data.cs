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

    public static class Data
    {
        public static IDictionary<string, int> CountWords(string text, IDictionary<string, int> wordsCount)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }

                wordsCount[word] = count;
            }

            return wordsCount;
        }

        public static void PrintOddOccurences(IDictionary<string, int> words)
        {
            Console.Write("{");
            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(" {0},", word.Key);
                }                
            }

            if (words.Count != 0)
            {
                Console.Write('\b' + " }" + '\n');
            }
            else
            {
                Console.Write(" Empty input data }" + '\n');
            }           
        }
    }
}