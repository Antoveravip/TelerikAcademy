/* Lesson 6 - Using Classes and Objects
 * Homework 2
 * 
 * Write a program that generates and prints to the 
 * console 10 random values in the range [100, 200].
 */

using System;

class GenerateAndPrintRandomNums
{
    static void Main()
    {
        Random generator = new Random();

        for (int i = 1; i <= 10; i++)
        {
            int randonNumber = generator.Next(100, 201);
            Console.WriteLine("{0} ", randonNumber);
        }
    }
}