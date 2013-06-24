/* Lesson 9 - Text Files
 * Homework 8
 * 
 * Modify the solution of the previous problem 
 * to replace only whole words (not substrings).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplacesWords
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
                    outputText.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = inputText.ReadLine();
                }
            }
        }
    }
}