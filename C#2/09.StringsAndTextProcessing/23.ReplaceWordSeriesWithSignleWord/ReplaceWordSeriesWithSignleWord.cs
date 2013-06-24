/* Lesson 9 - Strings and Text Processing
 * Homework 23
 * 
 * Write a program that reads a string from the 
 * console and replaces all series of consecutive
 * identical letters with a single one.
 * Example:
 * "aaaaabbbbbcdddeeeedssaa" --> "abcdedsa".
 */

using System;
using System.Text;

class ReplaceWordSeriesWithSignleWord
{
    static void Main()
    {
        //Test data
        string inputData = "aaaaabbbbbcdddeeeedffffssaaaahhhhh";

        /*
        //Data inputed from console
        Console.Write("Enter some series of consecutive identical letters: ");
        string inputData = Console.ReadLine();
        */

        StringBuilder removeDuplicates = new StringBuilder();
        removeDuplicates.Append(inputData[0]);
        for (int i = 1; i < inputData.Length; i++)
        {
            if (inputData[i] != removeDuplicates[removeDuplicates.Length - 1])
            {
                removeDuplicates.Append(inputData[i]);
            }
        }
        string replacedContent = removeDuplicates.ToString();
        Console.WriteLine("Afrer replaces all series of consecutive letters: {0}", removeDuplicates);
    }
}