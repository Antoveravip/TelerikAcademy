/* Lesson 9 - Strings and Text Processing
 * Homework 8
 * 
 * Write a program that extracts from a given
 * text all sentences containing given word.
 * Example:
 * The word is "in". The text is:
 * 
 * We are living in a yellow submarine. We don't have anything else.
 * Inside the submarine is very tight. So we are drinking all the day.
 * We will move out of it in 5 days.
 * 
 * The expected result is:
 * We are living in a yellow submarine.
 * We will move out of it in 5 days.
 * 
 * Consider that the sentences are separated by "." 
 * and the words – by non-letter symbols.
 */

using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        //Test strings
        string inputText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        /*
        //Strings inputed from console
        Console.Write("Write some text: ");
        string inputText = Console.ReadLine();
        Console.Write("Write with which word want to finds all sentence where the word is contained: ");
        string word = Console.ReadLine();
        */
        var sentences = Regex.Matches(inputText, @"\s*([^\.]*\b" + word + @"\b.*?\.)");

        foreach (Match sentence in sentences)
        {
            var foundSentence = sentence.Groups[1];
            Console.WriteLine(foundSentence);
        }
    }
}