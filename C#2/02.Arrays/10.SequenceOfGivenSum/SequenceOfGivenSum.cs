/* Lesson 2 - Arrays
 * Homework 10
 * 
 * Write a program that finds in given array of integers
 * a sequence of given sum S (if present).
 * 
 * Example:
 * {4, 3, 1, 4, 2, 5, 8}, S=11 --> {4, 2, 5}
 */

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        int sum = 0, index = 0, maxIndex = 0, subLength = 1, bestLength = 1;

        //Test array
        /*
        int[] inputArray = { 4, 3, 1, 4, 2, 5, 8 };
        int length = 7;
        int sumS = 11;
        */

        //Input needed sum S
        Console.Write("Enter sum value S: ");
        int sumS = int.Parse(Console.ReadLine());

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

        //Find the sequence with entered sum S
        for (int i = 0; i < length - 1; i++)
        {
            index = i;
            sum = inputArray[i];
            subLength = 1;
            for (int j = i + 1; j < length; j++)
            {
                subLength++;
                sum += inputArray[j];
                if (sum == sumS)
                {
                    if (subLength <= bestLength)
                    {
                        bestLength = subLength;
                        maxIndex = index;
                    }
                    else
                    {
                        bestLength = subLength;
                        maxIndex = index;
                    }
                }
            }
        }

        //Print result
        if (bestLength  != 1)
        {
            Console.Write("The sequence with entered sum " + sumS + " have " + bestLength + " elements. Sequence is:\n{");
            for (int i = maxIndex; i < (bestLength + maxIndex); i++)
            {
                Console.Write(" {0},", inputArray[i]);
            }
            Console.Write('\b' + " }" + '\n');
        }
        else
        {
            Console.WriteLine("No one sequence in that array have entered sum {0}", sumS);
        }

    }
}