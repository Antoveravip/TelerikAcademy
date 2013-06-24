/* Lesson 3 - Operators and Expressions
 * Homework 1
 * Write an expression that checks if given integer is odd or even.
 */

using System;

class OddOrEven
{
    static int enteredNumber;

    static void Main()
    {        
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Please enter an integer /exept zero/:");
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out enteredNumber);
            if (check = false || inputData.Length > 11 || enteredNumber == 0)
            {
                check = false;
                Console.WriteLine("Not correct integer number!");
            }
            else
            {
                check = true;
                enteredNumber = int.Parse(inputData);
            }
        }        
        if (enteredNumber % 2 != 0)
        {
            Console.WriteLine("The entered number {0} is odd", enteredNumber);
        }
        else
        {
            Console.WriteLine("The entered number {0} is even", enteredNumber);
        }
    }
}