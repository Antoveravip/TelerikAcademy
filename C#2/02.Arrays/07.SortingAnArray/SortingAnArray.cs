/* Lesson 2 - Arrays
 * Homework 7
 * 
 * Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. Use the "selection sort" algorithm:
 * Find the smallest element, move it at the first position, find the 
 * smallest from the rest, move it at the second position, etc.
 */

using System;

class SortingAnArray
{
    static void Main()
    {
        int minElem, elemHold = 0;

        //Test array
        /*
        int[] inputArray = {22, 28, 35, 8, 16, 32, 1, 9, 15, 6, 7};
        int length = 11;
        */

        //Reads length of array
        Console.Write("Enter the length of array: ");
        int length = int.Parse(Console.ReadLine());

        // Create array with entered size.
        int[] inputArray = new int[length];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < length; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        //Simple "selection sort" algorithm
        for (int i = 0; i < length - 1; i++)
        {
            minElem = i;
            for (int j = i + 1; j < length; j++)
            {
                if (inputArray[j] < inputArray[minElem])
                {
                    minElem = j;
                }
            }
            if (minElem != i)
            {
                elemHold = inputArray[i];
                inputArray[i] = inputArray[minElem];
                inputArray[minElem] = elemHold;
            }
        }

        //Print result
        Console.Write("Sorted array:\n{");
        for (int i = 0; i < length; i++)
        {
            Console.Write(" {0},", inputArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}