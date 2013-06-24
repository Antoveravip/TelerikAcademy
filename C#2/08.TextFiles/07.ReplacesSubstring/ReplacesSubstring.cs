/* Lesson 9 - Text Files
 * Homework 7
 * 
 * Write a program that replaces all occurrences of
 * the substring "start" with the substring "finish"
 * in a text file. Ensure it will work with large
 * files (e.g. 100 MB).
 */

using System;
using System.IO;

class ReplacesSubstring
{
    static void Main()
    {
        using (StreamReader inputText = new StreamReader("../../inputData.txt"))
        {
            using (StreamWriter outputText = new StreamWriter("../../outputData.txt"))
            {
                string line = inputText.ReadLine();
                while (line != null)
                {
                    outputText.WriteLine(line.Replace("start", "finish"));
                    line = inputText.ReadLine();
                }
            }
        }
    }
}