/* Lesson 4 - Methods
 * Homework 9
 * 
 * Write a method that return the maximal element 
 * in a portion of array of integers starting at 
 * given index. Using it write another method that
 * sorts an array in ascending / descending order.
 */

using System;

class MaxElementAndSort
{
    static void Main()
    {
        //Test arrays
        int[] inputArray = { 4, 7, 3, 1, 9, 4, 2, 5, 8, 7, 6, 7, 2, 1, 5, 7, 8, 2, 3, 1 };
        //int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int position = 0;
        bool order = false;

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
        Console.Write("Enter starting search position: ");
        int position = int.Parse(Console.ReadLine());

        byte type = 2;
        bool order = true;
        while (type < 0 || type > 1)
        {
            Console.Write("Enter search order /ascending - 1, descending - 0: ");
            type = byte.Parse(Console.ReadLine());
            if (type == 0) { order = true; }
            if (type == 1) { order = false; }
        }
        */
        int maxElement = MaxElement(position, inputArray, order);
        Console.WriteLine("The max element in array after position {0} is {1}", position, inputArray[maxElement]);
        SelectionSort(position, inputArray, order);
        PrintArray(inputArray);
    }

    static int MaxElement(int position, int[] array, bool order)
    {
        int maxElement = position;
        if (order == true)
        {
            for (int i = position; i < array.Length; i++)
            {
                if (array[i] > array[maxElement])
                {
                    maxElement = i;
                }
            }
        }
        if (order == false)
        {
            for (int i = position; i > 0; i--)
            {
                if (array[i] > array[maxElement])
                {
                    maxElement = i;
                }
            }
        }
        return maxElement;
    }

    static int[] SelectionSort(int position, int[] array, bool order)
    {
        int maxElem = position;
        for (int i = position; i < array.Length; i++)
        {
            maxElem = MaxElement(i, array, true);
            int elementHold = array[maxElem];
            array[maxElem] = array[i];
            array[i] = elementHold;
        }
        if (order == true)
        {
            return array;
        }
        else
        {
            Array.Reverse(array);
            return array;
        }
    }

    static void PrintArray(int[] array)
    {
        Console.Write("Sorted array:\n{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0},", array[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}