/* Lesson 2 - Arrays
 * Homework 9
 * 
 * Write a program that finds the most frequent number in an array.
 * 
 * Example:
 * {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --> 4 (5 times)
 */

using System;

class MostFrequentNumber
{
    static void Main()
    {
        int count = 0, maxCount = 0, num = 0, freqNum = 0;
        //Test array

        int[] inputArray = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
        int length = 13;
        
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
        //Find the most frequent number in the array
        for (int i = 0; i < length - 1; i++)
        {
            num = inputArray[i];
            count = 1;
            for (int j = i + 1; j < length; j++)
            {
                if (inputArray[i]==inputArray[j])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        freqNum = inputArray[i];
                    }                                 
                }
            }
        }
           
        //Print result
        Console.WriteLine("Most frequent number is " + freqNum + " (" + maxCount + " times)");
    }
}
