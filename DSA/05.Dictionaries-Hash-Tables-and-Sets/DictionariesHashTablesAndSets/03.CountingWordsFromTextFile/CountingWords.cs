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
    using System.Collections.Generic;
    using System.IO;

    public static class CountingWords
    {
        public static void Main()
        {
            // Test data            
            string path = @"..\..\words.txt";
            string text = string.Empty;

            // User test data - put your text in file wordsEx.txt  
            /*
            string path = @"..\..\wordsEx.txt";
            string text = string.Empty;
            */

            StreamReader inputData = new StreamReader(path);

            using (inputData)
            {
                text = inputData.ReadToEnd();
            }

            IDictionary<string, int> inputWords = new Dictionary<string, int>();
            IDictionary<string, int> words = Text.CountWords(text, inputWords);
            IDictionary<string, int> sortedWords = Text.SortByValue(words);
            Text.Print(sortedWords);
        }
    }
}