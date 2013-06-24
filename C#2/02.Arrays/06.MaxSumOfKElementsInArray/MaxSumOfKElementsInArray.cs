/* Lesson 2 - Arrays
 * Homework 6
 * 
 * Write a program that reads two integer numbers N
 * and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */

using System;

class MaxSumOfKElementsInArray
{
    static void Main()
    {
        int sum = 0, maxSum = 0, index = 0, maxIndex = 0;

        //Test array, N and K
        /*
        int[] inputArray = {5, 2, 3, 4, 5, 2, 1, 1, 5, 2, 3};
        int length = 11;
        int seqK = 3;
        */
        //Reads length N of array
        Console.Write("Enter the length of array: ");
        int length = int.Parse(Console.ReadLine());

        //Reads sequence K of array
        Console.Write("Enter sequence of elements K in array: ");
        int seqK = int.Parse(Console.ReadLine());

        // Create array with entered size.
        int[] inputArray = new int[length];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < length; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }
        
        //Calculate maximal sum of sequence K and start index of that sequence
        for (index = 0; index <= length - seqK; index++)
        {
            sum = 0;
            for (int j = index; j < seqK + index; j++)
            {
                sum += inputArray[j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                maxIndex = index;
            }
        }

        //Print result
        Console.Write("Maximal sum of sequence of " + seqK + " elements in that\narray have value " + maxSum + " and elements are:\n{");
        for (int i = maxIndex; i < (seqK + maxIndex); i++)
        {
            Console.Write(" {0},", inputArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}