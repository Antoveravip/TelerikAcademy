/* Lesson 9 - Strings and Text Processing
 * Homework 13
 * 
 * Write a program that reverses the words in given sentence.
 * Example:
 * "C# is not C++, not PHP and not Delphi!" -->
 * "Delphi not and PHP, not C++ not is C#!".
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReversesWords
{
    static void Main()
    {
        //Test string
        string inputData = "C# is not C++, not PHP and not Delphi!";

        /*
        //Strings inputed from console
        Console.Write("Write any url: ");
        string inputData = Console.ReadLine();
        */

        string regExp = @"\s+|,\s*|\.\s*|!\s*";
        List<string> words = new List<string>();
        List<string> separators = new List<string>();

        var data = Regex.Split(inputData, regExp);
        var matchSep = Regex.Matches(inputData, regExp);

        foreach (string word in data)
        {
            words.Add(word);
        }

        foreach (Match separator in matchSep)
        {
            separators.Add(separator.Value);
        }

        for (int i = 0; i < separators.Count; i++)
        {
            Console.Write(words[words.Count - 2 - i] + separators[i]);
        }
        Console.WriteLine();
    }
}