/* Lesson 3 - Operators and Expressions
 * Homework 11
 * Write an expression that extracts from a given 
 * integer i the value of a given bit number b.
 * Example:
 * i=5; b=2 --> value=1.
 */

using System;

class CheckValueOfBit
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
            Console.WriteLine("The bit of position {0} of entered integer {1} has value={2}", inputPosition, inputNumber, (result >> inputPosition));
        }
        else
        {
            Console.WriteLine("The bit of position {0} of entered integer {1} has value={2}", inputPosition, inputNumber, (result >> inputPosition));
        }
    }
}