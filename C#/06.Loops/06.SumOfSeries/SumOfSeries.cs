/* Lesson 6 - Loops
 * Homework 6
 * Write a program that, for a given two integer numbers N and X,
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
 */

using System;
using System.Numerics;

class SumOfSeries
{
    static BigInteger factorialN = 1;
    static decimal sum = 1, member;
    static uint n, x, k, power = 1, number;
    static string inputData;
    static bool check = false;

    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out number);
            if (check == false || inputData == "0")
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = uint.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Calculates the sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N");
        Console.Write("Enter N value for N!:");
        InputCheck();
        n = number;
        Console.Write("Enter X value for X:");
        InputCheck();
        x = number;
        for (k = 1; k <= n; k++)
        {
            factorialN *= k;
            power *= x;
            member = (decimal)factorialN / (decimal)power;
            sum = sum + member;
        }
        Console.WriteLine("The sum S = 1 + 1!/X + 2!/X2 + … + N!/XN\nwith entered falues for N={0} and X={1} is: {2:0.00}", n, x, sum);
    }
}