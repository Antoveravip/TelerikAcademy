/* Lesson 2 - Arrays
 * Homework 16*
 * 
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset 
 * of the elements of the array that has a sum S.
 * 
 * Example:
 * arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 --> yes (1+2+5+6)
 */

using System;

class SubElementSum
{
    static void Main()
    {
        //Test array

        int[] inputArray = { 4, 10, 3, 1, 9, 4, 2, 5, 8, 11, 6, 7, 2, 1, 5, 7 };
        int length = 16;
        int sumS = 5;

        /*
        //Input needed sum S
        Console.Write("Enter sum value S: ");
        int sumS = int.Parse(Console.ReadLine());

        //Reads length of array
        Console.Write("Enter the number of elements: ");
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
        //Find the sequence with entered sum S
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
            // With subcount > 1 we exclude subsets with one element.
            if (subcount > 1 && currentSum == sumS)
            {
                count++;
                Console.WriteLine("yes ({0})", subsets);
            }
            subsets = "";
        }
        if (count != 0)
        {
            Console.WriteLine("There is {0} sumbsets of elements, which sum is {1}!", count, sumS);
        }
        else
        {
            Console.WriteLine("No. There is no elements, which sum is {0}!", sumS);
        }
    }
}