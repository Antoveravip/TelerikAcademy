/* Lesson 9 - Text Files
 * Homework 9
 * 
 * Write a program that deletes from given text file
 * all odd lines. The result should be in the same file.
 */

using System;
using System.Collections.Generic;
using System.IO;

class DeletesOddLines
{
    static void Main()
    {
        string inputData = "../../inputData.txt";
        RewriteFile(inputData);
    }

    private static void RewriteFile(string inputData)
    {
        List<string> fileData = new List<string>();
        using (StreamReader data = new StreamReader(inputData))
        {
            string line = data.ReadLine();
            int lineNumber = 1;
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    fileData.Add(line);
                }
                line = data.ReadLine();
                lineNumber++;
            }
        }

        using (StreamWriter outputData = new StreamWriter(inputData))
        {
            for (int i = 0; i < fileData.Count; i++)
            {
                outputData.WriteLine(fileData[i]);
            }
        }
    }
}