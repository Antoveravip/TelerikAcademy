/* Lesson 2 - Arrays
 * Homework 18*
 * 
 * Write a program that reads an array of integers and removes 
 * from it a minimal number of elements in such way that the 
 * remaining array is sorted in increasing order. 
 * Print the remaining sorted array.
 * 
 * Example:
 * {6, 1, 4, 3, 0, 3, 6, 4, 5} --> {1, 3, 3, 4, 5}
 */

using System;

class RemainingSortedArray
{
    static void Main()
    {
        //Test arrays
        /*
        int[] inputArray = { 4, 10, 3, 1, 9, 4, 2, 5, 8, 11, 6, 7, 2, 1, 5, 7 };
        int length = 16;
        */

        int[] inputArray = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int length = 9;
        
        /*
        //Reads length of array
        Console.Write("Enter the number of elements - N: ");
        int length = int.Parse(Console.ReadLine());

        // Create array with entered size.
        int[] inputArray = new int[length];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < length; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }
        */
        //Find the solution
        int[] subLength = new int[length];
        int[] position = new int[length];

        int maxLength = 0;
        int bestIndex = 0;
        subLength[0] = 1;
        position[0] = -1;
        for (int i = 1; i < length; i++)
        {
            subLength[i] = 1;
            position[i] = -1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (subLength[j] + 1 > subLength[i] && inputArray[j] <= inputArray[i])
                {
                    subLength[i] = subLength[j] + 1;
                    position[i] = j;
                }
            }
            if (subLength[i] > maxLength)
            {
                bestIndex = i;
                maxLength = subLength[i];
            }
        }
        int[] bestSubSequence = new int[maxLength];
        Console.WriteLine("Max length = {0}", maxLength);
        Console.Write("Longest subsequences is:\n{");
        int index = bestIndex;
        for (int i = maxLength-1; i >= 0; i--)
        {
            bestSubSequence[i] = inputArray[index];
            index = position[index];
            if (index == -1)
            {
                break;
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(" {0},", bestSubSequence[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}