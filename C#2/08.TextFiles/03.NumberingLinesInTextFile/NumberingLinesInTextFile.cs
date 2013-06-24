/* Lesson 9 - Text Files
 * Homework 3
 * 
 * Write a program that reads a text file 
 * and inserts line numbers in front of 
 * each of its lines. The result should 
 * be written to another text file.
 */

using System;
using System.IO;

class NumberingLinesInTextFile
{
    static void Main()
    {
        int rowCount = 1;

        using (StreamReader inputData = new StreamReader("../../NumberingLinesInTextFile.cs"))
        {
            using (StreamWriter outputData = new StreamWriter("../../outputdata.txt"))
            {
                string row = inputData.ReadLine();
                while(row != null)
                {
                    outputData.WriteLine("{0}.{1}", rowCount, row);
                    rowCount++;
                    row = inputData.ReadLine();
                }
            }
        }
    }
}