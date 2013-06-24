/* Lesson 4 - Console Input Output
 * Homework 7
 * Write a program that gets a number n and after that
 * gets more n numbers and calculates and prints their sum. 
 */

using System;

class SumEnNumbers
{
    static decimal n1, n, k, sum;
    static void Main()
    {
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Enter the first number - n:");
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out n1);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                n1 = decimal.Parse(inputData);
                sum = n1;
                k = 1;
            }
        }
        check = false;
        for (k = 1; k <= n1; k++)
        {
            while (check != true)
            {
                Console.Write("Enter the next number - n:");
                inputData = Console.ReadLine();
                check = decimal.TryParse(inputData, out n);
                if (inputData == null || inputData == String.Empty || check == false)
                {
                    check = false;
                }
                else
                {
                    check = true;
                    n = decimal.Parse(inputData);
                    sum = sum + n;
                }
            }
            check = false;
        }
        Console.WriteLine("\nThe sum of all {0} numbers is {1}!\n", k, sum);
    }
}