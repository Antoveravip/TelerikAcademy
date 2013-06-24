/* Lesson 6 - Loops
 * Homework 1
 * Write a program that prints all the numbers from 1 to N.
 */

using System;

class PrintNumbersFrom1ToN
{
    static int n, inputNumber;
    static bool check = false;
    static string inputData;

    static void Main()
    {
        Console.Write("Enter number n:");
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out n);
            if (check == false || n <= 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                n = int.Parse(inputData);
            }
        }
        inputNumber = 1;
        Console.Write("The numbers are {0}", inputNumber);
        while (inputNumber < n)
        {
            inputNumber++;
            Console.Write(", {0}", inputNumber);
        }
        Console.WriteLine();
    }
}