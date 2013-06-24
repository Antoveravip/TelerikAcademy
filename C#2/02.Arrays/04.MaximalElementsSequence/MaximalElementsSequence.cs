/* Lesson 2 - Arrays
 * Homework 4
 * 
 * Write a program that finds the maximal 
 * sequence of equal elements in an array.
 * 
 * Example:
 * {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --> {2, 2, 2}.
 */

using System;

class MaximalElementsSequence
{
    static void Main()
    {
        int length = 0, maxLength = 0, index = 0, maxIndex = 0;

        //Test array
        /*
        int[] enteredArray = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        int arrayLength = 10;
        */

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

        //Checks for maximal sequence and begin index of that sequence
        for (int i = 0; i < arrayLength; i++)
        {
            if (i == 0)
            {
                length = 1;
                maxLength = 1;
                index = i;
            }
            if (i > 0 && enteredArray[i] != enteredArray[i - 1])
            {
                length = 1;
                index = i;
            }
            if (i > 0 && enteredArray[i] == enteredArray[i - 1])
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
        Console.Write("Maximal sequence of equal elements in that array have length " + maxLength + " and is:\n{");
        for (int i = maxIndex; i < (maxLength + maxIndex); i++)
        {
            Console.Write(" {0},", enteredArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}