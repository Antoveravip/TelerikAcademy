/* Lesson 6 - Advanced Data Structures
 * Homework 3
 * 
 * Write a program that finds a set of words (e.g. 1000 words) in a 
 * large text (e.g. 100 MB text file). Print how many times each
 * word occurs in the text.
 * Hint: you may find a C# trie in Internet.
 */

namespace WordCheking
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Occurencese
    {
        public static void Main(string[] args)
        {
            Stopwatch timeCheker = new Stopwatch();
            WordTrie wordsData = new WordTrie();
            var allWords = SetInputText();
            int wordsNumber = 200;

            List<string> wordsToSearch = new List<string>();

            for (int i = 0; i < wordsNumber; i++)
            {
                wordsToSearch.Add(allWords[i].ToString());
            }

            AddWordsForSearchInTrie(timeCheker, wordsData, wordsToSearch);
            IncrementOccuranceCountTrie(timeCheker, wordsData, allWords);

            Console.WriteLine("Searched words count trie: ");
            foreach (var word in wordsToSearch)
            {
                Console.WriteLine("{0} - {1} times", word, wordsData.CountWords(wordsData, word));
            }
        }        

        public static MatchCollection SetInputText()
        {
            string inputText;
            StreamReader text = new StreamReader("..\\..\\simple-text.txt");
            using (text)
            {
                inputText = text.ReadToEnd().ToLower();
            }

            var matches = Regex.Matches(inputText, @"[a-zA-Z]+");
            return matches;
        }

        private static void AddWordsForSearchInTrie(Stopwatch timeCheker, WordTrie wordsData, List<string> words)
        {
            timeCheker.Reset();
            timeCheker.Start();
            foreach (var item in words)
            {
                wordsData.AddWord(wordsData, item.ToString());
            }

            timeCheker.Stop();
            Console.WriteLine("Time for populating the trie: {0}\n", timeCheker.Elapsed);
        }

        private static void IncrementOccuranceCountTrie(Stopwatch timeCheker, WordTrie wordsData, MatchCollection allWords)
        {
            timeCheker.Reset();
            timeCheker.Start();
            foreach (var word in allWords)
            {
                wordsData.AddOccuranceIfExists(wordsData, word.ToString());
            }

            timeCheker.Stop();
            Console.WriteLine("Adding searched words count trie for: {0}", timeCheker.Elapsed);
        }        
    }
}