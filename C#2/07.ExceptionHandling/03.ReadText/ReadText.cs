﻿/* Lesson 7 - Exception Handling
 * Homework 3
 * 
 * Write a program that enters file name along with 
 * its full file path (e.g. C:\WINDOWS\win.ini), reads
 * its contents and prints it on the console. Find in
 * MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print
 * user-friendly error messages.
 */

using System;
using System.IO;
using System.Security;

class ReadText
{
    static void Main()
    {
        //Test read file
        //string filePath = "C:\trytoread.txt";

        Console.Write("Enter the full path of the file you want to read: ");
        string filePath = Console.ReadLine();

        try
        {
            ReadFilePath(filePath);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path contains a directory that cannot be found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file '{0}' was not found at this plase!", filePath);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long (248 characters are the maximum!)");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }

    static void ReadFilePath(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("The content of the file is: ");
        Console.WriteLine(fileContent);
    }
}