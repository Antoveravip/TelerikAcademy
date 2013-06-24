/* Lesson 9 - Text Files
 * Homework 1
 * 
 * Write a program that reads a text file 
 * and prints on the console its odd lines.
 */

using System;
using System.IO;

class PrintsOddLinesFromTextFile
{
    static void Main()
    {
        int rowCount = 7;

        using (StreamReader inputFile = new StreamReader("../../PrintsOddLinesFromTextFile.cs"))
        {
            string row = inputFile.ReadLine();
            while (row != null)
            {
                if (rowCount % 2 != 0)
                {
                    Console.WriteLine(row);
                }
                rowCount++;
                row = inputFile.ReadLine();
            }
        }
    }
}