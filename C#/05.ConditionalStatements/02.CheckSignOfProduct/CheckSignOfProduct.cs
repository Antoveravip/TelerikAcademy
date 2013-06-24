/* Lesson 5 - Conditional Statements
 * Homework 2
 * Write a program that shows the sign (+ or -) of the product of three 
 * real numbers without calculating it. Use a sequence of if statements.
 */

using System;

class CheckSignOfProduct
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

    // Assigning input values, check sign of the product ot the numbers without calculating it.
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
        if (firstNumber != 0 && secondNumber != 0 && thirdNumber != 0)
        {
            if (firstNumber > 0)
            {
                if (secondNumber < 0 ^ thirdNumber < 0)
                {
                    Console.WriteLine("The product of the numbers ({0}), ({1}) and ({2}) have (-) sign", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The product of the numbers ({0}), ({1}) and ({2}) have (+) sign", firstNumber, secondNumber, thirdNumber);
                }
            }
            if (firstNumber < 0)
            {
                if (secondNumber < 0 ^ thirdNumber < 0)
                {
                    Console.WriteLine("The product of the numbers ({0}), ({1}) and ({2}) have (+) sign", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The product of the numbers ({0}), ({1}) and ({2}) have (-) sign", firstNumber, secondNumber, thirdNumber);
                }
            }
        }
        else
        {
            Console.WriteLine("The product of the numbers ({0}), ({1}) and ({2}) is Zero", firstNumber, secondNumber, thirdNumber);
        }
    }
}