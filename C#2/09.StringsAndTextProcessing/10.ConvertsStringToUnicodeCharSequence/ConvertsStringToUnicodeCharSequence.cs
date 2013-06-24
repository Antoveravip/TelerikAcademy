/* Lesson 9 - Strings and Text Processing
 * Homework 10
 * 
 * Write a program that converts a string to a sequence
 * of C# Unicode character literals. Use format strings.
 * Sample input:
 * Hi!
 * 
 * Expected output:
 * \u0048\u0069\u0021
 */

using System;

class ConvertsStringToUnicodeCharSequence
{
    static void Main()
    {
        //Test strings
        string word = "Hi!";
        /*
        //Strings inputed from console
        Console.Write("Write some word to convert in Unicode chars: ");
        string word = Console.ReadLine();
        */

        string uniChars = "";
        for (int i = 0; i < word.Length; i++)
        {
            string uniSpecial = "\\u";
            string wordConv = Convert.ToString(((int)word[i]), 16).PadLeft(4, '0');
            uniChars = String.Format("{0}{1}{2}", uniChars, uniSpecial, wordConv);
        }
        Console.WriteLine(uniChars);
    }
}