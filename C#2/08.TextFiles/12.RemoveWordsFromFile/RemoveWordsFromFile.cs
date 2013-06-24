/* Lesson 9 - Text Files
 * Homework 12
 * 
 * Write a program that removes from a text file
 * all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class RemoveWordsFromFile
{
    static void Main()
    {
        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../wordsList.txt")) + @")\b";

            using (StreamReader inputData = new StreamReader("../../inputData.txt"))
            {
                using (StreamWriter outputData = new StreamWriter("../../outputData.txt"))
                {
                    string line = inputData.ReadLine();
                    while (line != null)
                    {
                        outputData.WriteLine(Regex.Replace(line, regex, String.Empty));
                        line = inputData.ReadLine();
                    }
                }
            }
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("Null Argument");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong Argument");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory to file not exist");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not exist");
        }
        catch (IOException)
        {
            Console.WriteLine("File exception");
        }
    }
}