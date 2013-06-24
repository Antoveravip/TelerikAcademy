/* Lesson 5 - Conditional Statements
 * Homework 3
 * Write a program that finds the biggest of three integers using nested if statements.
 */

using System;

class BiggestOfThreeIntegers
{
    static int firstNumber, secondNumber, thirdNumber, valueContainer;
    static string inputData;
    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out valueContainer);
            if (check == false)
            {
                Console.Write("Not correct integer number! Please enter again:");
            }
            else
            {
                check = true;
                valueContainer = int.Parse(inputData);
            }
        }
    }

    // Assigning input values and finds the biggest of three integers.
    static void Main()
    {
        Console.Write("Enter the first integer number:");
        InputCheck();
        firstNumber = valueContainer;
        Console.Write("Enter the second integer number:");
        InputCheck();
        secondNumber = valueContainer;
        Console.Write("Enter the third integer number:");
        InputCheck();
        thirdNumber = valueContainer;
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The biggest integer is the first number {0}", firstNumber);
            }
            if (firstNumber < thirdNumber)
            {
                Console.WriteLine("The biggest integer is the third number {0}", thirdNumber);
            }
            if (firstNumber == thirdNumber)
            {
                Console.WriteLine("The first and third number are equal. They both are biggest integers {0} and {1}", firstNumber, thirdNumber);
            }
        }
        if (firstNumber < secondNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The biggest integer is the second number {0}", secondNumber);
            }
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("The biggest integer is the third number {0}", thirdNumber);
            }
            if (secondNumber == thirdNumber)
            {
                Console.WriteLine("The second and third number are equal. They both are biggest integers {0} and {1}", secondNumber, thirdNumber);
            }
        }
        if (firstNumber == secondNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The first and second number are equal. They both are biggest integers {0} and {1}", firstNumber, secondNumber);
            }
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("The biggest integer is the third number {0}", thirdNumber);
            }
            if (secondNumber == thirdNumber)
            {
                Console.WriteLine("The first, second and third number are equal.\nNo one is biggest between them {0}, {1} and {2}", firstNumber, secondNumber, thirdNumber);
            }
        }
    }
}