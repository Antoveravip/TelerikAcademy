/* Lesson 9 - Text Files
 * Homework 11
 * 
 * Write a program that deletes from a text file
 * all words that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeletesSpecificWord
{
    static void Main()
    {
        using (StreamReader inputData = new StreamReader("../../inputData.txt"))
        {
            using (StreamWriter outputData = new StreamWriter("../../outputData.txt"))
            {
                string line = inputData.ReadLine();
                while (line != null)
                {
                    outputData.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                    line = inputData.ReadLine();
                }
            }
        }
    }
}