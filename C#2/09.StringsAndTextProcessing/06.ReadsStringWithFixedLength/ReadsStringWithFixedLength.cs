/* Lesson 9 - Strings and Text Processing
 * Homework 6
 * 
 * Write a program that reads from the console a string
 * of maximum 20 characters. If the length of the string 
 * is less than 20, the rest of the characters should be 
 * filled with '*'. Print the result string into the console.
 */

using System;

class ReadsStringWithFixedLength
{
    static void Main()
    {
        //Test string
        //string inputData = "Write a program that reads from the console";
        string inputData = Console.ReadLine();
        int maxChars = 20;
        char fillCharToMax = '*';

        if (inputData.Length > maxChars)
        {
            Console.WriteLine(inputData.Remove(maxChars));
        }
        if (inputData.Length < maxChars)
        {
            Console.WriteLine(inputData.PadRight(maxChars, fillCharToMax));
        }
    }
}