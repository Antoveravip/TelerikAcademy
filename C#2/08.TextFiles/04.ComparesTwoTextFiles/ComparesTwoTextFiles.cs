/* Lesson 9 - Text Files
 * Homework 4
 * 
 * Write a program that compares two text files
 * line by line and prints the number of lines
 * that are the same and the number of lines
 * that are different. Assume the files have 
 * equal number of lines.
 */

using System;
using System.IO;

class ComparesTwoTextFiles
{
    public static int equalRows;
    public static int diffRows;

    static void Main()
    {
        string firstFile = "../../first.txt";
        string secondFile = "../../second.txt";

        CompareTwoFiles(firstFile, secondFile);
    }

    public static void CompareTwoFiles(string firstFile, string secondFile)
    {
        equalRows = 0;
        diffRows = 0;

        using (StreamReader firstReader = new StreamReader(firstFile))
        {
            using (StreamReader secondReader = new StreamReader(secondFile))
            {
                string oneRow = firstReader.ReadLine();
                string anotherOneRow = secondReader.ReadLine();

                while (oneRow != null && anotherOneRow != null)
                {
                    if (oneRow == anotherOneRow)
                    {
                        equalRows++;
                    }
                    else
                    {
                        diffRows++;
                    }
                    oneRow = firstReader.ReadLine();
                    anotherOneRow = secondReader.ReadLine();
                }
            }
        }
        Console.WriteLine("From all {0} lines, there are {1} equal lines and {2} different lines!", equalRows + diffRows, equalRows, diffRows);
    }
}