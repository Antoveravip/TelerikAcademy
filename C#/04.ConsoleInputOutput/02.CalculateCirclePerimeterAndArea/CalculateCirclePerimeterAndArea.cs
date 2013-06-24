/* Lesson 4 - Console Input Output
 * Homework 2
 * Write a program that reads the radius r of a circle and prints its perimeter and area.
 */

using System;
using System.Globalization;

class CalculateCirclePerimeterAndArea
{
    static decimal radius, circlePerimeter, circleArea;
    static string inputData;
    static bool check = false;
    // Check input data
    static void InputCheck()
    {
        CultureInfo culturInf = null;
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out radius);
            foreach (char c in inputData)
            {
                if (c < '0' || c > '9' || inputData == "0")
                {
                    check = false;
                }
                if (c == '.' || c == ',')
                {
                    check = true;
                }
            }            
            if (check == false )
            {
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine();
                try
                {
                    culturInf = CultureInfo.CreateSpecificCulture("en-US");
                    radius = decimal.Parse(inputData, culturInf);
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    culturInf = CultureInfo.CreateSpecificCulture("bg-BG");
                    try
                    {
                        radius = decimal.Parse(inputData, culturInf);
                        Console.WriteLine("You entered radius - {0} cm.\n", radius);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse entered width '{0}'.", inputData);
                    }
                }
                inputData = inputData.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
            }
        }
    }

    static void Main()
    {
        decimal pi = (decimal)Math.PI;
        Console.WriteLine("Calculating circle’s perimeter and area by given radius!");
        Console.Write("Enter radius value:");
        InputCheck();
        //Calculating of the circle's perimeter and area
        circlePerimeter = 2 * pi * radius;
        circleArea = pi * radius * radius;
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("You entered radius - {0:0.00} cm.", radius);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The circle's perimeter is {0:0.00} cm.", circlePerimeter);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The circle's area is {0:0.00} square cm.", circleArea);
        Console.WriteLine(new string('-', 50) + "\n");
    }
}