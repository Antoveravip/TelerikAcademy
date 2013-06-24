/* Lesson 6 - Loops
 * Homework 3
 * Write a program that reads from the console a sequence of
 * N integer numbers and returns the minimal and maximal of them.
 */

using System;

class MinAndMaxOfASequence
{
    static byte n;
    static int number, minimal, maximal;
    static string inputData;
    static bool check = false;
    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out number);
            if (check == false)
            {
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
        Console.Write("Enter how many numbers you want to compare. n =");
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = byte.TryParse(inputData, out n);
            if (check == false || inputData == "0")
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                n = byte.Parse(inputData);
            }
        }
        Console.Write("Enter the number:");
        InputCheck();
        minimal = number;
        maximal = number;
        for (int i = 1; i < n; i++)
        {
            Console.Write("Enter the number:");
            InputCheck();
            if (number >= maximal)
            {
                maximal = number;
            }
            if (number <= minimal)
            {
                minimal = number;
            }
        }
        Console.WriteLine("From entered sequence of numbers:\n- biggest = {0}\n- smallest = {1}", maximal, minimal);
    }
}