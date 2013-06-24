/* Lesson 2 - Arrays
 * Homework 8
 * 
 * Write a program that finds the sequence of maximal sum in given array.
 * 
 * Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
 * 
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        int sum = 0, maxSum = 0, index = 0, maxIndex = 0, subLength = 1, bestLength = 1;
        //Test array
        
        int[] inputArray = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        int length = 10;
        
        /*
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
        */
        //Find the sequence of maximal sum
        for (int i = 0; i < length - 1; i++)
        {
            index = i;
            sum = inputArray[i];
            subLength = 1;
            for (int j = i + 1; j < length; j++)
            {
                subLength++;                
                sum += inputArray[j];
                if (sum >= maxSum)
                {
                    if (sum == maxSum && subLength <= bestLength)
                    {
                        bestLength = subLength;
                        maxIndex = index;
                    }
                    if (sum > maxSum)
                    {
                        bestLength = subLength;
                        maxIndex = index;
                    }
                    maxSum = sum;                    
                }
            }
        }
           
        //Print result
        Console.Write("The sequence with maximal sum have " + bestLength + " elements and value " + maxSum + ". Sequence is:\n{");
        for (int i = maxIndex; i < (bestLength + maxIndex); i++)
        {
            Console.Write(" {0},", inputArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}
