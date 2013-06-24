/* Lesson 5 - Conditional Statements
 * Homework 6
 * Write a program that enters the coefficients a, b and c of a quadratic
 * equation a*x2 + b*x + c = 0 and calculates and prints its real roots.
 * Note that quadratic equations may have 0, 1 or 2 real roots.
 */

using System;

class QuadraticEquation
{
    static decimal a, b, c, x1, x2, discriminant, coefficient;
    static string inputData;

    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out coefficient);
            if (check == false || inputData == "0")
            {
                check = false;
                Console.Write("Not correct coefficient value! Please enter again:");
            }
            else
            {
                check = true;
                coefficient = decimal.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        //Assigning input values
        Console.Write("Enter value for the first coefficient - a:");
        InputCheck();
        a = coefficient;
        Console.Write("Enter value for the second coefficient - b:");
        InputCheck();
        b = coefficient;
        Console.Write("Enter value for the third coefficient - c:");
        InputCheck();
        c = coefficient;
        // Solving the quadratic equation with entered coefficients.
        //Trying quickly find the roots of quadratic equation - without calculating discriminant
        if ((a + b + c) == 0)
        {
            x1 = 1;
            x2 = c / a;
            Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has two real roots: x1 = {3:0.00} and x2 = {4:0.00}.\n", a, b, c, x1, x2);
        }
        if ((a - b + c) == 0)
        {
            x1 = -1;
            x2 = (-c) / a;
            Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has two real roots: x1 = {3:0.00} and x2 = {4:0.00}.\n", a, b, c, x1, x2);
        }
        //Finding the roots with discriminant
        if (((a + b + c) != 0) && ((a - b + c) != 0))
        {
            discriminant = (b * b) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has no real roots.\n", a, b, c);
            }
            if (discriminant == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has one real (double) root: x = {3:0.00}.\n", a, b, c, x1);
            }
            if (discriminant > 0)
            {
                x1 = ((-b) + (decimal)(Math.Sqrt((double)discriminant))) / (2 * a);
                x2 = ((-b) - (decimal)(Math.Sqrt((double)discriminant))) / (2 * a);
                Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has two distinct real roots: x1 = {3:0.00} and x2 = {4:0.00}.\n", a, b, c, x1, x2);
            }
        }
    }
}