/* Lesson 2 - Arrays
 * Homework 5
 * 
 * Write a program that finds the maximal
 * increasing sequence in an array.
 * 
 * Example:
 * {3, 2, 3, 4, 2, 2, 4} --> {2, 3, 4}.
 */

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int length = 0, maxLength = 0, index = 0, maxIndex = 0;

        //Test array
        
        int[] enteredArray = {1, 2, 4, 6, 7, 2, 1, 2, 3, 5};
        int arrayLength = 10;
        
        /*
        //Array entered from console
        Console.Write("Enter the length of array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        // Create array with entered size.
        int[] enteredArray = new int[arrayLength];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < arrayLength; i++)
        {
            enteredArray[i] = int.Parse(Console.ReadLine());
        }
        */
        //Checks for maximal increasing sequence and begin index of that sequence
        for (int i = 0; i < arrayLength; i++)
        {
            if (i == 0)
            {
                length = 1;
                maxLength = 1;
                index = i;
            }
            if (i > 0 && enteredArray[i] != enteredArray[i - 1] + 1)
            {
                length = 1;
                index = i;
            }
            if (i > 0 && enteredArray[i] == enteredArray[i - 1] + 1)
            {
                length++;
                if (length > maxLength)
                {
                    maxIndex = index;
                    maxLength = length;
                }
            }
        }

        //Print result
        Console.Write("Maximal sequence of increasing elements in that array have length " + maxLength + " and is:\n{");
        for (int i = maxIndex; i < (maxLength + maxIndex); i++)
        {
            Console.Write(" {0},", enteredArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}