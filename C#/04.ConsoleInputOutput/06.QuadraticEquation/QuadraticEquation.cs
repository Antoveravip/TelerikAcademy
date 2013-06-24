/* Lesson 4 - Console Input Output
 * Homework 6
 * Write a program that reads the coefficients a, b and c 
 * of a quadratic equation ax2+bx+c=0 and solves it
 * (prints its real roots).
 */

using System;

class QuadraticEquation
{
    static decimal a, b, c, x1, x2, discriminant;
    static void Main()
    {
        //Input and check input data
        bool check = false;
        string inputData;
        while (check != true)
        {
            Console.Write("Enter the first coefficient - a:");
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out a);
            if (inputData == null || inputData == String.Empty || check == false || inputData == "0")
            {
                check = false;
            }
            else
            {
                check = true;
                a = decimal.Parse(inputData);
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter the second coefficient - b:");
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out b);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                b = decimal.Parse(inputData);
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter the third coefficient - c:");
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out c);
            if (inputData == null || inputData == String.Empty || check == false)
            {
                check = false;
            }
            else
            {
                check = true;
                c = decimal.Parse(inputData);
            }
        }
        // Solving the quadratic equation with entered coefficients.
        if ((a + b + c) == 0)
        {
            x1 = 1;
            x2 = c / a;
            Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has two real roots: x1 = {3:0.00} and x2 = {4:0.00}!\n", a, b, c, x1, x2);
        }
        if ((a - b + c) == 0)
        {
            x1 = -1;
            x2 = (-c) / a;
            Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has two real roots: x1 = {3:0.00} and x2 = {4:0.00}!\n", a, b, c, x1, x2);
        }
        if (((a + b + c) !=0) && ((a - b + c) != 0))
        {
            discriminant = (b * b) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has no real roots!\n", a, b, c);
            }
            if (discriminant == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has one real (double) root: x = {3}!\n", a, b, c, x1);
            }
            else
            {
                x1 = ((-b) + (decimal)(Math.Sqrt((double)discriminant))) / (2 * a);
                x2 = ((-b) - (decimal)(Math.Sqrt((double)discriminant))) / (2 * a);
                Console.WriteLine("\nWith entered coefficients a = {0}, b = {1} and c = {2} the quadratic\nequation has two distinct real roots: x1 = {3} and x2 = {4}!\n", a, b, c, x1, x2);
            }
        }
    }
}