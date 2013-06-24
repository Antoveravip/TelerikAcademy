/* Lesson 3 - Operators and Expressions
 * Homework 5
 * Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
 */

using System;

class BitPositionValue
{
    static int inputNumber;
    static bool check = false;
    static string inputData;

    static void Main()
    {
        Console.Write("Enter an integer number:");
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out inputNumber);
            if (check == false || inputNumber < 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                inputNumber = int.Parse(inputData);
            }
        }
        int position = 3;
        int mask = 1 << position;
        int result = inputNumber & mask;
        if ((result >> position) != 1)
        {
            Console.WriteLine("The bit of position {0} of entered integer is 0", position);
        }
        else
        {
            Console.WriteLine("The bit of position {0} of entered integer is 1", position);
        }
    }
}