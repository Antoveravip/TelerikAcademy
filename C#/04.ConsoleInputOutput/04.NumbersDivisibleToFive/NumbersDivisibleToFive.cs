/* Lesson 4 - Console Input Output
 * Homework 4
 * Write a program that reads two positive integer numbers and prints 
 * how many numbers p exist between them such that the reminder of the
 * division by 5 is 0 (inclusive).
 * 
 * Example: p(17,25) = 2.
 */

using System;

class NumbersDivisibleToFive
{
    static uint firstNumber, lastNumber, countDivisibleNumber;
    static void Main()
    {
        //Input and check input data
        bool check = false;
        string inputData;        
        while (check != true)
        {
            Console.WriteLine("Enter first positive integer:");
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out firstNumber);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                firstNumber = uint.Parse(inputData);
            }
        }
        check = false;        
        while (check != true)
        {
            Console.WriteLine("Enter last positive integer:");
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out lastNumber);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                lastNumber = uint.Parse(inputData);
            }
            if (lastNumber <= firstNumber )
            {
                check = false;
            }
        }
        // Calculating the numbers in entered range
        countDivisibleNumber = ((lastNumber + (5 - (lastNumber % 5))) - (firstNumber + (5 - (firstNumber % 5)))) / 5;
        Console.WriteLine("Count numbers divisible to five in range between {0} and {1} is: {2}", firstNumber, lastNumber, countDivisibleNumber);
    }
}