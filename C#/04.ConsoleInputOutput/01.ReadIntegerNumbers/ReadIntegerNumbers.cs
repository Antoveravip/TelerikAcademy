/* Lesson 4 - Console Input Output
 * Homework 1
 * Write a program that reads 3 integer numbers from the console and prints their sum.
 */

using System;

class ReadIntegerNumbers
{
    static int number, x, y, z, sum = 0;

    // Check input data
    static void InputCheck()
    {
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Enter an integer number:");
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out number);
            if (check == false)
            {
                Console.Write("Not correct integer number!");
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
        Console.WriteLine("Enter 3 integer numbers.");
        InputCheck();
        x = number;
        InputCheck();
        y = number;
        InputCheck();
        z = number;
        sum = x + y + z;
        Console.WriteLine("You entered {0}, {1} and {2}. The sum of this numbers is {3}\n", x, y, z, sum);
    }
}