/* Lesson 9 - Text Files
 * Homework 6
 * 
 * Write a program that reads a text file containing a list 
 * of strings, sorts them and saves them to another text file.
 * Example:
 * Ivan			    George
 * Peter  --->  	Ivan
 * Maria			Maria
 * George			Peter
 */

using System;
using System.Collections.Generic;
using System.IO;

class ReadsSortStringFile
{
    static void Main()
    {
        List<string> textLines = ReadLinesFromFile();
        textLines.Sort();
        WriteLinesToFile(textLines);
    }

    static List<string> ReadLinesFromFile()
    {
        List<string> textLines = new List<string>();

        using (StreamReader input = new StreamReader("../../inputData.txt"))
        {
            string line = input.ReadLine();
            while (line != null)
            {
                textLines.Add(line);
                line = input.ReadLine();
            }
        }
        return textLines;
    }

    static void WriteLinesToFile(List<string> textLines)
    {
        using (StreamWriter output = new StreamWriter("../../outputData.txt"))
        {
            foreach (string line in textLines)
            {
                output.WriteLine(line);
            }
        }
    }
}