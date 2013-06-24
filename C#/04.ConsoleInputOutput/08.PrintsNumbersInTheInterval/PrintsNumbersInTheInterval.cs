/* Lesson 4 - Console Input Output
 * Homework 8
 * Write a program that reads an integer number n from the
 * console and prints all the numbers in the interval [1..n], 
 * each on a single line.
 */

using System;

class PrintsNumbersInTheInterval
{
    static int n;
    static void Main()
    {
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Enter the integer number n for the end of interval [1 - n]:");
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out n);
            if (inputData == null || inputData == String.Empty || check == false || inputData == "0")
            {
                check = false;
                Console.Write("Not correct integer number! Please enter again:");
            }
            else
            {
                check = true;
                n = int.Parse(inputData);
            }
        }
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine("The number is {0}", k);
        }
    }
}