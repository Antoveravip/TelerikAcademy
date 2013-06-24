/* Lesson 3 - Multidimensional Arrays
 * Homework 5
 * 
 * You are given an array of strings. Write a method
 * that sorts the array by the length of its elements 
 * (the number of characters composing them). 
 */

using System;

class SorteingStringsArray
{
    static void Main()
    {
        //Test string array
        string[] textArray = {"Zagorka", "Ariana", "Shumensko","Astika", 
                              "Kamenitza", "Bolqrka", "Amstel"};

        /*
        // Read the length of array
        Console.Write("Enter number of elements of string array: ");
        int length = int.Parse(Console.ReadLine());

         // Create array with entered size.
        string[] textArray = new string[length];

        // Get from console element values of array
        Console.WriteLine("Enter the elements value of array:");
        for (int i = 0; i < length; i++)
        {
            textArray[i] = Console.ReadLine();
        }
        */

        // One way with Array.Sort and defalt comparer - CompareStringsByLength
        Array.Sort(textArray, CompareStringsByLength);

        Console.WriteLine("Sorted: {0}", String.Join(", ", textArray));
    }

    public static int CompareStringsByLength(string first, string second)
    {
        if (first == null)
        {
            if (second == null)  //Are equal.
            {
                return 0;
            }
            else //Second is greater.  
            {
                return -1;
            }
        }
        else
        {
            if (second == null) //First is greater                
            {
                return 1;
            }
            else //compare the lengths of the two strings. 
            {
                int returnValue = first.Length.CompareTo(second.Length);

                if (returnValue != 0) // If the strings are not of equal length, the longer string is greater. 
                {
                    return returnValue;
                }
                else // If the strings are of equal length, sort them with ordinary string comparison. 
                {
                    return first.CompareTo(second);
                }
            }
        }
    }
}