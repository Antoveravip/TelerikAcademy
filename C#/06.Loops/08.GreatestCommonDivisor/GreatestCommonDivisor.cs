/* Lesson 6 - Loops
 * Homework 8
 * Write a program that calculates the greatest common divisor (GCD) of
 * given two numbers. Use the Euclidean algorithm (find it in Internet).
 */

using System;

class GreatestCommonDivisor
{
    static decimal numA, numB, dividend, divisor, remainder, number;
    static string inputData;
    static bool check = false;

    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out number);
            if (check == false || inputData == "0" || inputData == "1")
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = decimal.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter value for first number A=");
        InputCheck();
        numA = number;
        Console.Write("Enter value for second number B=");
        InputCheck();
        numB = number;
        while (numB == numA)
        {
            Console.WriteLine("Not correct value for B. Try again: B=");
            InputCheck();
            numB = number;
        }
        //Check for greatest number
        if (numA > numB)
        {
            dividend = numA;
            divisor = numB;
        }
        if (numA < numB)
        {
            dividend = numB;
            divisor = numA;
        }
        while (divisor != 0)
        {
            remainder = dividend % divisor;
            dividend = divisor;
            divisor = remainder;
        }
        Console.WriteLine("Greatest common divisor (GCD) of numbers {0} and {1} is: {2}", numA, numB, dividend);
    }
}