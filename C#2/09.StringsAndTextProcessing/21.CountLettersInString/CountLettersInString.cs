/* Lesson 9 - Strings and Text Processing
 * Homework 21
 * 
 * Write a program that reads a string from 
 * the console and prints all different letters 
 * in the string along with information how many 
 * times each letter is found. 
 */

using System;

class CountLettersInString
{
    static void Main()
    {
        //Test text
        string inputData = "Lesson 9 - Strings and Text Processing. Homework 21. Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

        /*
        //Data inputed from console
        Console.Write("Enter text to check how many times is used each letter: ");
        string inputData = Console.ReadLine();
        */

        int[] letters = new int['z' - 'a' + 1];

        foreach (char ch in inputData.ToLower())
        {
            if ('a' <= ch && ch <= 'z')
            {
                letters[ch - 'a']++;
            }
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] != 0)
            {
                Console.WriteLine("{0}: {1}", (char)(i + 'a'), letters[i]);
            }
        }
    }
}