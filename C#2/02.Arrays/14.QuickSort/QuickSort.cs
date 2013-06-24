/* Lesson 2 - Arrays
 * Homework 14
 * 
 * Write a program that sorts an array of strings using
 * the quick sort algorithm (find it in Wikipedia).
 */

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        //Test array

        List<int> inputArray = new List<int>() {170, 11, 22, 1, 122, 7, 0, 102, -1, 116, -5, 114, 48, 6, -3, 16, 5, -11, 3};

        /* 
        //Reads length of array
        Console.Write("Enter the length of array: ");
        int length = int.Parse(Console.ReadLine());

        // Create array with entered size.
        List<int> inputArray = new List<int>(length);

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < length; i++)
        {
            inputArray.Add(int.Parse(Console.ReadLine()));           
        }
        */

        List<int> sortedArray = QuickSortArray(inputArray);

        Console.Write("Sorted array:\n{");
        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.Write(" {0},", sortedArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }

    static List<int> QuickSortArray(List<int> inputArray)
    {
        if (inputArray.Count <= 1)
        {
            return inputArray;
        }

        int divided = inputArray.Count / 2;
        int pivot = inputArray[divided];

        List<int> less = new List<int>();
        List<int> larger = new List<int>();

        for (int i = 0; i < inputArray.Count; i++)
        {
            if (i != (divided))
            {
                if (inputArray[i] <= pivot)
                {
                    less.Add(inputArray[i]);
                }
                else
                {
                    larger.Add(inputArray[i]);
                }
            }
        }
        return ArraysConcatenation(QuickSortArray(less), pivot, QuickSortArray(larger));
    }

    static List<int> ArraysConcatenation(List<int> less, int pivot, List<int> greater)
    {
        List<int> concatenation = new List<int>();

        for (int i = 0; i < less.Count; i++)
        {
            concatenation.Add(less[i]);
        }

        concatenation.Add(pivot);

        for (int i = 0; i < greater.Count; i++)
        {
            concatenation.Add(greater[i]);
        }
        return concatenation;
    }
}