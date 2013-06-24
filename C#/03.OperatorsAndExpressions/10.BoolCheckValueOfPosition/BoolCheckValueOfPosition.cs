/* Lesson 3 - Operators and Expressions
 * Homework 10
 * Write a boolean expression that returns if the bit at position p
 * (counting from 0) in a given integer number v has value of 1.
 * Example:
 * v=5; p=1 --> false.
 */

using System;

class BoolCheckValueOfPosition
{
    static int inputNumber, number;

    static void InputCheck()
    {
        bool check = false;
        string inputData;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out number);
            if (check == false || number < 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = int.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter integer number:");
        InputCheck();
        inputNumber = number;
        Console.Write("Enter the wanted position:");
        InputCheck();
        int inputPosition = number;
        int mask = 1 << inputPosition;
        int result = inputNumber & mask;
        if ((result >> inputPosition) != 1)
        {
            Console.WriteLine("False! The bit of position {0} of entered integer is 0", inputPosition);
        }
        else
        {
            Console.WriteLine("True! The bit of position {0} of entered integer is 1", inputPosition);
        }
    }
}