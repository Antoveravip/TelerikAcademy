/* Lesson 3 - Operators and Expressions
 * Homework 8
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

using System;
using System.Globalization;

class TrapezoidsArea
{
    static class sideA
    {
        public static decimal Number;
    }
    static class sideB
    {
        public static decimal Number;
    }
    static class height
    {
        public static decimal Number;
    }
    static void Main()
    {
        decimal trapezoidsArea;
        string inputData;
        bool checkAll = false;
        CultureInfo culturInf = null;
        //Start input, culture and other checks for all inputing elements
        do
        {
            Console.WriteLine("Calculating trapezoid’s area by given side A, side B and height!");
            Console.Write("Enter the length of side A: ");
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
                Console.WriteLine("You didn't enter correct length!");
                Console.WriteLine();
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    culturInf = CultureInfo.CreateSpecificCulture("en-US");
                    sideA.Number = decimal.Parse(inputData, culturInf);
                    Console.WriteLine("You entered length of - {0} cm. for side A\n", sideA.Number);
                }
                catch (FormatException)
                {
                    culturInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        sideA.Number = decimal.Parse(inputData, culturInf);
                        Console.WriteLine("You entered length of - {0} cm. for side A\n", sideA.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse entered length '{0}'.", inputData);
                    }
                }
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
            }
        }
        while (checkAll != true);
        do
        {
            Console.Write("Enter the length of side B: ");
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
                Console.WriteLine("You didn't enter correct length!\n");
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    culturInf = CultureInfo.CreateSpecificCulture("en-US");
                    sideB.Number = decimal.Parse(inputData, culturInf);
                    Console.WriteLine("You entered length of - {0} cm. for side B\n", sideB.Number);
                }
                catch (FormatException)
                {
                    culturInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        sideB.Number = decimal.Parse(inputData, culturInf);
                        Console.WriteLine("You entered length of - {0} cm. for side B\n", sideB.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse entered length '{0}'.", inputData);
                    }
                }
            }
        }
        while (checkAll != true);
        do
        {
            Console.Write("Enter height of trapezoid: ");
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
                Console.WriteLine("You didn't enter correct height!\n");
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    culturInf = CultureInfo.CreateSpecificCulture("en-US");
                    height.Number = decimal.Parse(inputData, culturInf);
                    Console.WriteLine("You entered height - {0} cm.\n", height.Number);
                }
                catch (FormatException)
                {
                    culturInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        height.Number = decimal.Parse(inputData, culturInf);
                        Console.WriteLine("You entered height - {0} cm.\n", height.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse entered height '{0}'.", inputData);
                    }
                }
            }
        }
        while (checkAll != true);
        //Calculating of the trapezoid's area
        trapezoidsArea = ((sideA.Number + sideB.Number) / 2) * height.Number;
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("You entered length of - {0} cm. for side A,\nlength of - {1} cm. for side B and height - {2} cm.", sideA.Number, sideB.Number, height.Number);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The trapezoid's area is {0} square cm.", trapezoidsArea);
        Console.WriteLine(new string('-', 50) + "\n");
    }
}