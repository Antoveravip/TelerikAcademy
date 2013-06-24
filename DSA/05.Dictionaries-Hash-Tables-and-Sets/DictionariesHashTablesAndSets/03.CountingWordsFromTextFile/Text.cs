/* Lesson 5 - Dictionaries Hash Tables And Sets
 * Homework 3
 * 
 * Write a program that counts how many times each word from given 
 * text file words.txt appears in it. The character casing differences 
 * should be ignored. The result words should be ordered by their number
 * of occurrences in the text.
 * Example:
 * 
 * This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
 * 
 * is --> 2
 * the --> 2
 * this --> 3
 * text --> 6
 */

namespace _03.CountingWordsFromTextFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Text
    {
        public static IDictionary<string, int> CountWords(string text, IDictionary<string, int> wordsCount)
        {
            text = text.ToLower();
            text = text.Replace('–', ' ');
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

        public static IDictionary<string, int> SortByValue(IDictionary<string, int> words)
        {
            IDictionary<string, int> sortedWords = new Dictionary<string, int>();

            foreach (var word in words.OrderBy(key => key.Value).ThenBy(key => key.Key))
            {
                sortedWords.Add(word);
            }

            return sortedWords;
        }

        public static void Print(IDictionary<string, int> words)
        {
            if (words.Count == 0)
            {
                Console.Write("Emty input data!");
            }
            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
                }
            }
        }
    }
}