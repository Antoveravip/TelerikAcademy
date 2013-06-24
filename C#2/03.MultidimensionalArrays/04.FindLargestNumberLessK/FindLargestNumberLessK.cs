/* Lesson 3 - Multidimensional Arrays
 * Homework 4
 * 
 * Write a program, that reads from the console an array of N 
 * integers and an integer K, sorts the array and using the 
 * method Array.BinSearch() finds the largest number in the
 * array which is ≤ K. 
 */

using System;

class FindLargestNumberLessK
{
    static void Main()
    {
        //Test array
        int[] inputArray = { -11, -5, -3, -1, 0, 1, 3, 5, 6, 7, 11, 16, 22, 48, 102, 114, 116, 122, 135, 170, 181 };
        int k = 23;
        /*
        //Reads length of array
        Console.Write("Enter the length N of array: ");
        int lengthN = int.Parse(Console.ReadLine());

        // Create array with entered size.
        int[] inputArray = new int[lengthN];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < lengthN; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        //Enter a wanted value of K
        Console.Write("Enter value of K: ");
        int wantedElement = int.Parse(Console.ReadLine());
        */

        //Before start binary search the array must be aways sorted
        int searchValue;
        Array.Sort(inputArray);
        //Using method Array.BinarySearch() from .NET
        if (inputArray[0] > k)
        {
            Console.WriteLine("No one number in entered array is less than or equal to entered value of K.");
        }
        else
        {
            int index = Array.BinarySearch(inputArray, k);
            if (index >= 0)
            {
                searchValue = inputArray[index];
            }
            else
            {
                searchValue = inputArray[~index - 1];
            }
            Console.WriteLine("The element response to the condition E <= K is {0}.", searchValue);
        }
    }
}