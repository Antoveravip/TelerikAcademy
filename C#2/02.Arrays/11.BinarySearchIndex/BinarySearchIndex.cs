/* Lesson 2 - Arrays
 * Homework 11
 * 
 * Write a program that finds the index of given
 * element in a sorted array of integers by using
 * the binary search algorithm (find it in Wikipedia).
 */

using System;

class BinarySearchIndex
{
    static void Main()
    {
        // Binary search or half-interval search algorithm finds the position
        // of a specified value (the input "key") within a sorted array.

        int wantedIndex = 0;
        bool indexFind = false;
        //Test array

        int[] inputArray = { -11, -5, -3, -1, 0, 1, 3, 5, 6, 7, 11, 16, 22, 48, 102, 114, 116, 122, 135, 170, 181 };
        int length = 21;
        int wantedElement = 3;

        /*
        //Enter a wanted value of the element
        Console.Write("Enter a wanted value of the element: ");
        int wantedElement = int.Parse(Console.ReadLine());

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
                
        //Because using of "Binary search". Just in case we can do increasing sort of array. 
        //If array is not sorted - must first be sorted and after that bynary search.
        // And that is slow and not good practice!
        //Array.Sort(inputArray);
        */
        //Find the index of wanted element
        int middle = 0, left = 0, right = 0;
        if (inputArray[0] > inputArray[length - 1]) // for decreasing sorted array
        {
            left = length - 1;
            right = 0;

        }
        else // for increasing sorted array
        {
            left = 0;
            right = length - 1;
        }

        while (indexFind != true)
        {
            middle = left + ((right - left) / 2);
            if (inputArray[middle] == wantedElement)
            {
                wantedIndex = middle;
                indexFind = true;
                break;
            }
            else
            {
                if (inputArray[middle] > wantedElement)
                {
                    right = middle - 1;
                }
                if (inputArray[middle] < wantedElement)
                {
                    left = middle + 1;
                }
            }
        }

        //Print result
        Console.WriteLine("The index of wanted element " + wantedElement + " in that array is {0}", wantedIndex);
    }
}