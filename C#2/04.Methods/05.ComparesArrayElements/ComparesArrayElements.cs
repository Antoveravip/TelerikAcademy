/* Lesson 4 - Methods
 * Homework 5
 * 
 * Write a method that checks if the element at given
 * position in given array of integers is bigger than
 * its two neighbors (when such exist).
 */

using System;

class ComparesArrayElements
{
    static void Main()
    {
        //Test array and position
        int[] array = { 4, 7, 3, 1, 9, 4, 2, 5, 8, 7, 6, 7, 2, 1, 5, 7, 8, 2, 3, 1 };
        int position = 4;
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
        
        //Enter a wanted position
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        */

        string size = CompareElementsInArray(position, array);
        Console.WriteLine("The element {0} of position {1} is {2}.", array[position], position, size);
    }

    public static string CompareElementsInArray(int position, int[] array)
    {
        string size = "";
        if (position > 0 && position < array.Length - 1)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                size = "bigger than its two neighbors";
            }
            else
            {
                size = "not bigger than its two neighbors";
            }
        }
        if ((position == 0 && array[position] > array[position + 1]) ||
            (position == array.Length - 1 && array[position] > array[position - 1]))
        {
            size = "bigger than its only one neighbor";
        }
        else if ((position == 0 && array[position] < array[position + 1]) ||
                 (position == array.Length - 1 && array[position] < array[position - 1]))
        {
            size = "not bigger than its only one neighbor";
        }
        return size;
    }
}