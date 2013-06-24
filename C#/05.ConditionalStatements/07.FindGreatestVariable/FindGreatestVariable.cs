/* Lesson 5 - Conditional Statements
 * Homework 7
 * Write a program that finds the greatest of given 5 variables.
 */

using System;

class FindGreatestVariable
{
    static decimal variable, lowest, greatest;
    static string inputData;

    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out variable);
            if (check == false)
            {
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                variable = decimal.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        //One way is using loop for!
        Console.Write("Enter the number:");
        InputCheck();
        lowest = variable;
        greatest = variable;
        for (int i = 1; i < 5; i++)
        {
            Console.Write("Enter the number:");
            InputCheck();
            if (variable >= greatest)
            {
                greatest = variable;
            }
            if (variable <= lowest)
            {
                lowest = variable;
            }
        }
        Console.WriteLine("From entered sequence of numbers - greatest is {0}\n", greatest);
    }
}