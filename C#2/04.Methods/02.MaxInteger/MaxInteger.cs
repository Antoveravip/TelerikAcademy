/* Lesson 4 - Methods
 * Homework 2
 * 
 * Write a method GetMax() with two parameters that returns
 * the bigger of two integers. Write a program that reads 3 
 * integers from the console and prints the biggest of them
 * using the method GetMax().
 */

using System;

class MaxInteger
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxValue = firstNumber;
        if (secondNumber > firstNumber)
        {
            maxValue = secondNumber;
        }
        return maxValue;
    }

    static void Main()
    {
        Console.WriteLine("Please enter an integer number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter another integer number:");
        int secondNumber = int.Parse(Console.ReadLine());

        int maxValue = GetMax(firstNumber, secondNumber);

        Console.WriteLine("Please enter another integer number:");
        int thirdNumber = int.Parse(Console.ReadLine());

        maxValue = GetMax(maxValue, thirdNumber);
        Console.WriteLine("The biggest from entered numbers {0}, {1} and {2} is {3}", firstNumber, secondNumber, thirdNumber, maxValue);
    }
}