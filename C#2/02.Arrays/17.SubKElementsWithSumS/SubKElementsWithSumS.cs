/* Lesson 2 - Arrays
 * Homework 17*
 * 
 * Write a program that reads three integer numbers N, K
 * and S and an array of N elements from the console.
 * Find in the array a subset of K elements that have sum
 * S or indicate about its absence.
 */

using System;

class SubKElementsWithSumS
{
    static void Main()
    {
        //Test array

        int[] inputArray = { 4, 10, 3, 1, 9, 4, 2, 5, 8, 11, 6, 7, 2, 1, 5, 7 };
        int length = 16;
        int elemNumK = 3;
        int sumS = 5;

        /*
        //Reads length of array
        Console.Write("Enter the number of elements - N: ");
        int length = int.Parse(Console.ReadLine());

        //Input needed number K of all elements
        Console.Write("Enter number of subset elements - K: ");
        int elemNumK = int.Parse(Console.ReadLine());

        //Input needed sum S
        Console.Write("Enter sum value S: ");
        int sumS = int.Parse(Console.ReadLine());

        // Create array with entered size.
        int[] inputArray = new int[length];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < length; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }
        */
        //Find the sequence from K elements with entered sum S
        int count = 0;
        string subsets = "";
        for (int i = 1; i <= (int)Math.Pow((double)2, length) - 1; i++)
        {
            int currentSum = 0;
            int subcount = 0;
            for (int j = 0; j < length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    subcount++;
                    currentSum += inputArray[j];
                    if (subcount == 1)
                    {
                        subsets += "" + inputArray[j];
                    }
                    else
                    {
                        subsets += " + " + inputArray[j];
                    }
                }
            }
            // With subcount == elemNumK we avoid subsets which number of elements are different.
            if (subcount == elemNumK && currentSum == sumS)
            {
                count++;
                Console.WriteLine("Subset ({0}), with {1} elements have sum {2}", subsets, elemNumK, sumS);
            }
            subsets = "";
        }
        if (count != 0)
        {
            Console.WriteLine("There is {0} subsets of {1} elements, which sum is {2}!", count, elemNumK, sumS);
        }
        else
        {
            Console.WriteLine("There is no one subsets of {0} elements, which sum is {0}!", elemNumK, sumS);
        }
    }
}