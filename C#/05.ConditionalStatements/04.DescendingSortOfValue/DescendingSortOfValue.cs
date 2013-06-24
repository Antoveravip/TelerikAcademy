/* Lesson 5 - Conditional Statements
 * Homework 4
 * Sort 3 real values in descending order using nested if statements.
 */

using System;

class DescendingSortOfValue
{
    static decimal firstNumber, secondNumber, thirdNumber, valueContainer;
    static string inputData;

    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out valueContainer);
            if (check == false)
            {
                Console.Write("Not correct integer number! Please enter again:");
            }
            else
            {
                check = true;
                valueContainer = decimal.Parse(inputData);
            }
        }
    }

    // Assigning input values and sort values in descending order.
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
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("The descending order is {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                }
                if (secondNumber < thirdNumber)
                {
                    Console.WriteLine("The descending order is {0}, {2}, {1}", firstNumber, secondNumber, thirdNumber);
                }
                if (secondNumber == thirdNumber)
                {
                    Console.WriteLine("The second and third number are equal.\nThe descending order is {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                }
            }
            if (firstNumber < thirdNumber)
            {
                Console.WriteLine("The descending order is {2}, {0}, {1}", firstNumber, secondNumber, thirdNumber);
            }
            if (firstNumber == thirdNumber)
            {
                Console.WriteLine("The first and third number are equal.\nThe descending order is {0}, {2}, {1}", firstNumber, secondNumber, thirdNumber);
            }
        }
        if (firstNumber < secondNumber)
        {
            if (secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("The descending order is {1}, {0}, {2}", firstNumber, secondNumber, thirdNumber);
                }
                if (firstNumber < thirdNumber)
                {
                    Console.WriteLine("The descending order is {1}, {2}, {0}", firstNumber, secondNumber, thirdNumber);
                }
                if (firstNumber == thirdNumber)
                {
                    Console.WriteLine("The first and third number are equal.\nThe descending order is {1}, {0}, {2}", firstNumber, secondNumber, thirdNumber);
                }
            }
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("The descending order is {2}, {1}, {0}", firstNumber, secondNumber, thirdNumber);
            }
            if (secondNumber == thirdNumber)
            {
                Console.WriteLine("The second and third number are equal.\nThe descending order is {1}, {2}, {0}", firstNumber, secondNumber, thirdNumber);
            }
        }
        if (firstNumber == secondNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The first and second number are equal.\nThe descending order is {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            }
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("The first and second number are equal.\nThe descending order is {2}, {0}, {1}", firstNumber, secondNumber, thirdNumber);
            }
            if (secondNumber == thirdNumber)
            {
                Console.WriteLine("The first, second and third number are equal.\nNo one is smallest between them.\nThere is no way for descending order - {0}, {1} and {2}", firstNumber, secondNumber, thirdNumber);
            }
        }
    }
}