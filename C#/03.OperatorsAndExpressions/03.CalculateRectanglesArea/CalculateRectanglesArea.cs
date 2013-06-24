/* Lesson 3 - Operators and Expressions
 * Homework 3
 * Write an expression that calculates rectangle’s area by given width and height.
 */

using System;
using System.Globalization;

class CalculateRectanglesArea
{
    static class widthSize
    {
        public static decimal Number;
    }
    static class heightSize
    {
        public static decimal Number;
    }
    static void Main()
    {
        decimal rectanglesArea;
        string inputData;
        bool checkAll = false;
        CultureInfo culturInf = null;
        do
        {
            Console.WriteLine("Calculating rectangle’s area by given width and height!");
            Console.Write("Enter width of rectangle: ");
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
                Console.WriteLine("You didn't enter correct width!");
                Console.WriteLine();
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    culturInf = CultureInfo.CreateSpecificCulture("en-US");
                    widthSize.Number = decimal.Parse(inputData, culturInf);
                    Console.WriteLine("You entered width - {0} cm.\n", widthSize.Number);
                }
                catch (FormatException)
                {
                    culturInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        widthSize.Number = decimal.Parse(inputData, culturInf);
                        Console.WriteLine("You entered width - {0} cm.\n", widthSize.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse entered width '{0}'.", inputData);
                    }
                }
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
            }
        }
        while (checkAll != true);
        do
        {
            Console.Write("Enter height of rectangle: ");
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
                    heightSize.Number = decimal.Parse(inputData, culturInf);
                    Console.WriteLine("You entered height - {0} cm.\n", heightSize.Number);
                }
                catch (FormatException)
                {
                    culturInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        heightSize.Number = decimal.Parse(inputData, culturInf);
                        Console.WriteLine("You entered height - {0} cm.\n", heightSize.Number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse entered height '{0}'.", inputData);
                    }
                }
            }
        }
        while (checkAll != true);
        //Calculating of the rectangle's area
        rectanglesArea = widthSize.Number * heightSize.Number;
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("You entered width - {0} cm. and height - {1} cm.", widthSize.Number, heightSize.Number);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The rectangle's area is {0} square cm.", rectanglesArea);
        Console.WriteLine(new string('-', 50) + "\n");
    }
}