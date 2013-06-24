/* Lesson 2 - Arrays
 * Homework 1
 * Write a program that allocates array of 20 integers and
 * initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
 */

using System;

class InitializingArray
{
    static void Main()
    {
        int[] firstArray = new int[20];

        // Next code show default elements value in new allocated array
        int length = firstArray.Length;
        Console.Write("The allocates array have elements with value -\n{");
        for (int i = 0; i < length; i++)
        {
            Console.Write(" {0},", firstArray[i]);
        }
        Console.Write('\b' + " }" + '\n');

        // This code initializes each element by its index multiplied by 5.
        // And print each element of the obtained array on the console.
        Console.Write("The initializing array have elements with value -\n{");
        for (int index = 0; index < length; index++)
        {
            firstArray[index] = index * 5;
            Console.Write(" {0},", firstArray[index]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}