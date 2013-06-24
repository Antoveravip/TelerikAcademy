/* Lesson 2 - Arrays
 * Homework 3
 * 
 * Write a program that compares two char arrays
 * lexicographically (letter by letter).
 */

using System;

class ComparesCharArrays
{
    static void Main()
    {
        //Test check
        /*
        int arrayLength = 5;
        char[] firstCharArray = {'H', 'e', 'l', 'l', 'o'};
        char[] secondCharArray = {'W', 'o', 'r', 'l', 'd'};
        */

        Console.Write("Enter the length of arrays: ");
        int arrayLength = int.Parse(Console.ReadLine());

        // Create of tho arrays with entered size.
        char[] firstCharArray = new char[arrayLength];
        char[] secondCharArray = new char[arrayLength];

        // Get from console element values of each array
        Console.WriteLine("Enter the elements value of first array:");
        for (int i = 0; i < arrayLength; i++)
        {
            firstCharArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the elements value of second array:");
        for (int i = 0; i < arrayLength; i++)
        {
            secondCharArray[i] = char.Parse(Console.ReadLine());
        }

        //Compares entered arrays element by element and print result
        Console.WriteLine("Compares entered arrays element by element.");
        Console.Write("{");
        for (int i = 0; i < arrayLength; i++)
        {
            if (firstCharArray[i] != secondCharArray[i])
            {
                Console.Write(" {0} != {1},", firstCharArray[i], secondCharArray[i]);
            }
            else
            {
                Console.Write(" {0} == {1},", firstCharArray[i], secondCharArray[i]);
            }
        }
        Console.Write('\b' + " }" + '\n');
    }
}