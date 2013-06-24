/* Lesson 3 - Operators and Expressions
 * Homework 6
 * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
 */

using System;

class PointInCircle
{
    static double number;
    // Check input data
    static void InputCheck()
    {
        string inputData;
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = double.TryParse(inputData, out number);
            if (check == false)
            {
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = double.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        double circleX = 0;
        double circleY = 0;
        double radius = 5; 
        Console.WriteLine("To check if the point is within a circle K, please enter coordinates\nof the point.\n");
        Console.Write("Enter X coordinate:");
        InputCheck();
        double pointX = number;
        Console.Write("Enter Y coordinate:");
        InputCheck();
        double pointY = number;
        double calculation = Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2);
        if (Math.Sqrt(calculation) <= radius)
        {
            Console.WriteLine("The chosen point with coordinates ({0},{1}) is within a circle K (({2},{3}),{4})", pointX, pointY, circleX, circleY, radius);
        }
        else 
        {
            Console.WriteLine("The chosen point with coordinates ({0},{1}) is outside of a circle K (({2},{3}),{4})", pointX, pointY, circleX, circleY, radius);           
        }
    }
}