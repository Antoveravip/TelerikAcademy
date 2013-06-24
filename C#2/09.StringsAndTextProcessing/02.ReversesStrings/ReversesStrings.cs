/* Lesson 9 - Strings and Text Processing
 * Homework 2
 * 
 * Write a program that reads a string, reverses
 * it and prints the result at the console.
 * Example: "sample" --> "elpmas".
 */

using System;
using System.Text;

class ReversesStrings
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        //One way
        string reversed = "";
        for (int i = 0; i < inputString.Length; i++)
        {
            reversed = inputString[i] + reversed;
        }
        Console.WriteLine("Reversed string is: {0}", reversed);

        //Another with StringBuilder
        StringBuilder reversd = new StringBuilder();
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversd.Append(inputString[i]);
        }
        Console.WriteLine("Reversed string is: {0}", reversd.ToString());
    }
}