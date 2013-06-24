/* Lesson 4 - Methods
 * Homework 6
 * 
 * Write a method that returns the index of the first element in
 * array that is bigger than its neighbors, or -1, if there’s no
 * such element. Use the method from the previous exercise.
 */

using System;

class FindIndexOfBiggerThanNeighbors
{
    static void Main()
    {
        //Test arrays
        int[] array = { 4, 7, 3, 1, 9, 4, 2, 5, 8, 7, 6, 7, 2, 1, 5, 7, 8, 2, 3, 1 };
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

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
        int position = 0, firstBestPosition = 0;
        for (int i = 1; i < array.Length; i++)
        {
            position = i;
            firstBestPosition = CompareElementsInArray(position, array);
            if (firstBestPosition == 1)
            {
                Console.WriteLine("The first element that is bigger than its neighbors is {0} and have index {1}", array[position], position);
                break;
            }
        }
        if (firstBestPosition != 1)
        {
            Console.WriteLine("No one element is bigger than its neighbors in that array");
        }

    }

    public static int CompareElementsInArray(int position, int[] array)
    {
        if (position > 0 && position < array.Length - 1)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        else
        {
            return -1;
        }
    }
}