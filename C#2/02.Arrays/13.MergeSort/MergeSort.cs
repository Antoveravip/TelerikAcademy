/* Lesson 2 - Arrays
 * Homework 13*
 * 
 * Write a program that sorts an array of integers using
 * the merge sort algorithm (find it in Wikipedia).
 */

using System;

class MergeSort
{
    static void Main()
    {
        //Test array

        int[] inputArray = { 170, 11, 22, 1, 122, 7, 0, 102, -1, 181, 116, 135, -5, 114, 48, 6, -3, 16, 5, -11, 3 };

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
        int[] sortedArray = MergeSortArrays(inputArray);

        Console.Write("Sorted array:\n{");
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write(" {0},", sortedArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }

    public static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }
        return result;
    }

    public static int[] MergeSortArrays(int[] inputArray)
    {
        if (inputArray.Length <= 1)
        {
            return inputArray;
        }

        int middle = inputArray.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[inputArray.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = inputArray[i];
        }

        for (int i = middle, j = 0; i < inputArray.Length; i++, j++)
        {
            rightArray[j] = inputArray[i];
        }

        leftArray = MergeSortArrays(leftArray);
        rightArray = MergeSortArrays(rightArray);

        return MergeArrays(leftArray, rightArray);
    }
}