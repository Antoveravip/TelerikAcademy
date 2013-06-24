/* Lesson 5 - Conditional Statements
 * Homework 1
 * Write an if statement that examines two integer variables and exchanges 
 * their values if the first one is greater than the second one.
 */

using System;

class ExchangesValues
{
    static int firstValue, secondValue, valueContainer;
    static string inputData;
    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out valueContainer);
            if (check == false || inputData == "0")
            {
                check = false;
                Console.Write("Not correct integer number! Please enter again:");
            }
            else
            {
                check = true;
                valueContainer = int.Parse(inputData);
            }
        }
    }

    // Assigning input values, check if first one is greater that second one and if - exchange their values
    static void Main()
    {
        Console.Write("Enter the first integer number:");
        InputCheck();
        firstValue = valueContainer;
        Console.Write("Enter the second integer number:");
        InputCheck();
        secondValue = valueContainer;
        if (firstValue > secondValue)
        {
            Console.WriteLine("You enter first number {0}, and second {1}", firstValue, secondValue);
            valueContainer = firstValue;
            firstValue = secondValue;
            secondValue = valueContainer;
            Console.WriteLine("The first value was exchanged with the second one.\nAnd now first number is {0}, and second - {1}", firstValue, secondValue);
        }
        else
        {
            Console.WriteLine("You enter first number {0}, and second {1}", firstValue, secondValue);
        }
    }
}