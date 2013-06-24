/* Lesson 9 - Strings and Text Processing
 * Homework 14
 * 
 * A dictionary is stored as a sequence of text lines containing 
 * words and their explanations. Write a program that enters a
 * word and translates it by using the dictionary. 
 * Sample dictionary:
 * 
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes
 */

using System;
using System.Text.RegularExpressions;

class FindDictionaryExplanations
{
    static void Main()
    {
        string[] dictionary = {".NET - platform for applications from Microsoft",
                               "CLR - managed execution environment for .NET",
                               "namespace - hierarchical - organization of classes"};
        string word = ".NET";

        foreach (string exp in dictionary)
        {
            var snippets = Regex.Match(exp, "(.*?) - (.*)").Groups;

            if (snippets[1].Value == word)
            {
                Console.WriteLine("{0} - {1}", word, snippets[2]);
                return;
            }
        }
    }
}