/* Lesson 6 - Loops
 * Homework 12
 * Write a program that reads from the console a positive integer
 * number N (N < 20) and outputs a matrix like the following:
 * 
 *  N = 3	        N = 4
 * 
 *  1 2 3           1 2 3 4
 *  2 3 4           2 3 4 5
 *  3 4 5           3 4 5 6
 *                  4 5 6 7
 */

using System;

class PrintsNMatrix
{
    static byte n, number, row, col;
    static string inputData;
    static bool check = false;

    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = byte.TryParse(inputData, out number);
            if (check == false || number >= 20)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = byte.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter value for N=");
        InputCheck();
        n = number;
        //The visual formatting working well till n=15
        Console.WriteLine(new string('-', n * 5 + 1));
        for (row = 1; row <= n; row++)
        {
            for (col = row; col <= (row + n - 1); col++)
            {
                Console.Write("| {0,2} ", col);
            }
            Console.Write("|\n");
            Console.WriteLine(new string('-', n * 5 + 1));
        }
    }
}