/* Lesson 9 - Strings and Text Processing
 * Homework 22
 * 
 * Write a program that reads a string from the
 * console and lists all different words in the
 * string along with information how many times
 * each word is found.
 */

using System;
using System.Collections.Generic;

class CountWordsInString
{
    static void Main()
    {
        //Test data
        string inputData = "Lesson 9 - Strings and Text Processing. Homework 22. Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

        /*
        //Data inputed from console
        Console.Write("Enter text to check how many times is used each word: ");
        string inputData = Console.ReadLine();
        */

        string[] words = inputData.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word] = dictionary[word] + 1;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }

        foreach (var word in dictionary)
        {
            Console.WriteLine("{0,-20} - {1} times", word.Key, word.Value);
        }
    }
}