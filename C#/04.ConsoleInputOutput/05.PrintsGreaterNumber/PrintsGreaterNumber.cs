/* Lesson 4 - Console Input Output
 * Homework 5
 * Write a program that gets two numbers from the console
 * and prints the greater of them. Don’t use if statements.
 */

using System;

class PrintsGreaterNumber
{
    static decimal firstNumber, secondNumber, greaterNumber;
    static void Main()
    {
        //Input and check input data
        bool check = false;
        string inputData;
        while (check != true)
        {
            Console.WriteLine("Enter first number:");
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out firstNumber);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                firstNumber = decimal.Parse(inputData);
            }
        }
        check = false;
        while (check != true)
        {
            Console.WriteLine("Enter second number:");
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out secondNumber);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                secondNumber = decimal.Parse(inputData);
            }
        }
        // Calculating the greater number between entered numbers
        // One way
        greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("One way with Math.Max:\nGreater number is {0}\n", greaterNumber);
        //Another
        greaterNumber = (firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber)) / 2;
        Console.WriteLine("Another - with Math.Abs:\nGreater number is {0}\n", greaterNumber);
    }
}