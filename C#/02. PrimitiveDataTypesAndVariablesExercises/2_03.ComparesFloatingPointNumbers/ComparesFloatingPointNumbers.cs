/* Lesson 2 - Primitive Data Types and Variables
 * Homework 3
 * Write a program that safely compares floating-point
 * numbers with precision of 0.000001.
 * Examples:
 * (5.3 ; 6.01) --> false;
 * (5.00000001 ; 5.00000003) --> true
 */

using System;
using System.Globalization;

class ComparesFloatingPointNumbers
{
    static class First
    {
        public static decimal Number;
    }
    static class Second
    {
        public static decimal Number;
    }
    static void Main()
    {
        //Declare of variables
        decimal mathPrecision = 0.000001m;
        string inputData;
        //decimal firstNumber;
        //decimal secondNumber;
        bool checkAll = false;
        CultureInfo cultInf = null;
        do
        {
            Console.WriteLine("Compares two floating-point numbers with precision of 0.000001");
            Console.WriteLine("Enter the first floating-point number:");
            inputData = Console.ReadLine();
            bool checkFormat = true;
            foreach (char c in inputData)
            {
                if (c < '0' || c > '9')
                {
                    checkFormat = false;
                    if (c == '.' || c == ',')
                    {
                        checkFormat = true;
                    }
                }
            }
            checkAll = checkFormat && (inputData != null && inputData != String.Empty);
            if (checkAll != true)
            {
                Console.WriteLine("You didn't enter correct first number!");
                Console.WriteLine();
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    cultInf = CultureInfo.CreateSpecificCulture("en-US");
                    First.Number = decimal.Parse(inputData, cultInf);
                    Console.WriteLine("You enter {0}:", First.Number);
                }
                catch (FormatException)
                {
                    cultInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        First.Number = decimal.Parse(inputData, cultInf);
                        Console.WriteLine("You enter {0}:", First.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse '{0}'.", inputData);
                    }
                }
            }
        }
        while (checkAll != true);
        do
        {
            Console.WriteLine("Enter the second floating-point number:");
            inputData = Console.ReadLine();
            bool checkFormat = true;
            foreach (char c in inputData)
            {
                if (c < '0' || c > '9')
                {
                    checkFormat = false;
                    if (c == '.' || c == ',')
                    {
                        checkFormat = true;
                    }
                }
            }
            checkAll = false;
            checkAll = checkFormat && (inputData != null && inputData != String.Empty);
            if (checkAll != true)
            {
                Console.WriteLine("You didn't enter correct second number!");
                Console.WriteLine();
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    cultInf = CultureInfo.CreateSpecificCulture("en-US");
                    Second.Number = decimal.Parse(inputData, cultInf);
                    Console.WriteLine("You enter {0}:", Second.Number);
                }
                catch (FormatException)
                {
                    cultInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        Second.Number = decimal.Parse(inputData, cultInf);
                        Console.WriteLine("You enter {0}:", Second.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse '{0}'.", inputData);
                    }
                }
            }
        }
        while (checkAll != true);
        //compares floating-point numbers with precision of 0.000001
        decimal numDifference = First.Number - Second.Number;
        if ((Math.Abs(numDifference)) >= mathPrecision)
        {
            Console.WriteLine("False! This numbers are not equal");
        }
        else
        {
            Console.WriteLine("True. This numbers are equal according required precision!");
        }
    }
}