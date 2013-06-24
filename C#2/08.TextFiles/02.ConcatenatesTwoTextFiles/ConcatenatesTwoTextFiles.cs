/* Lesson 9 - Text Files
 * Homework 2
 * 
 * Write a program that concatenates two
 * text files into another text file.
 */

using System;
using System.IO;

class ConcatenatesTwoTextFiles
{
    static void Main()
    {
        string[] files = { "../../ConcatenatesTwoTextFiles.cs", "../../ConcatenatesTwoTextFiles.cs" };

        using (StreamWriter outputData = new StreamWriter("../../outputdata.txt"))
        {
            foreach (string file in files)
            {
                WriteToFile(outputData, file);
            }
        }
    }

    static void WriteToFile(StreamWriter output, string file)
    {
        using (StreamReader inputData = new StreamReader(file))
        {
            string line = inputData.ReadLine();
            while(line != null)
            {
                output.WriteLine(line);
                line = inputData.ReadLine();
            }
        }
    }
}