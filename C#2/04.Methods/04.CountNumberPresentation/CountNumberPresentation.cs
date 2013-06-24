/* Lesson 4 - Methods
 * Homework 4
 * 
 * Write a method that counts how many times given number
 * appears in given array. Write a test program to check
 * if the method is working correctly.
 */

using System;

class CountNumberPresentation
{
    static int NumberRepresentation(int number, int[] array)
    {
        int count = 0;
        foreach (int element in array)
        {
            if (element == number)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        //Test array and number
        int[] array = { 4, 7, 3, 1, 9, 4, 2, 5, 8, 7, 6, 7, 2, 1, 5, 7, 8, 2, 3, 1 };
        int number = 2;

        int count = NumberRepresentation(number, array);
        Console.WriteLine("The number {0} is represented in {1} elements in that array.", number, count);
    }
}