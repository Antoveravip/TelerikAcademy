/* Lesson 2 - Arrays
 * Homework 2
 * 
 * Write a program that reads two arrays from the
 * console and compares them element by element.
 */

using System;

class ComparesIntArrays
{
    static void Main()
    {
        Console.Write("Enter the length of arrays: ");
        int arrayLength = int.Parse(Console.ReadLine());

        // Create of tho arrays with entered size.
        int[] firstArray = new int[arrayLength];
        int[] secondArray = new int[arrayLength];

        // Get from console element values of each array and print value
        Console.WriteLine("Enter the elements value of first array:");
        for (int i = 0; i < arrayLength; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the elements value of second array:");
        for (int i = 0; i < arrayLength; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //Compares entered arrays element by element
        Console.WriteLine("Compares entered arrays element by element.");
        Console.Write("{");
        for (int i = 0; i < arrayLength; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.Write(" false,");
            }
            else
            {
                Console.Write(" true,");
            }
        }
        Console.Write('\b' + " }" + '\n');
    }
}