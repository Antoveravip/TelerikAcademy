/* Lesson 3 - Operators and Expressions
 * Homework 9
 * Write an expression that checks for given point (x, y)
 * if it is within the circle K( (1,1), 3) and out of the
 * rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;

class PointWithinCircleOutRectangle
{
    static double number;

    static void InputCheck()
    {
        bool check = false;
        string inputData;
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
                number = double.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        double circleX = 1;
        double circleY = 1;
        double radius = 3;
        double rectangleX = -1;
        double rectangleY = 1;
        double rectangleWidth = 6;
        double rectangleHeight = 2;
        Console.WriteLine("To check if the point is within a circle K, please enter coordinates\nof the point.\n");
        Console.Write("Enter X coordinate:");
        InputCheck();
        double pointX = number;
        Console.Write("Enter Y coordinate:");
        InputCheck();
        double pointY = number;
        double calculation = Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2);
        //Check if is within a circle K
        if (Math.Sqrt(calculation) <= radius)
        {
            Console.WriteLine("The chosen point with coordinates ({0},{1})\nis within a circle K (({2},{3}),{4})\n", pointX, pointY, circleX, circleY, radius);
        }
        else
        {
            Console.WriteLine("The chosen point with coordinates ({0},{1})\nis outside of a circle K (({2},{3}),{4})\n", pointX, pointY, circleX, circleY, radius);
        }
        //Check if the point is out of rectangle R
        if ((pointX < rectangleX) || (pointX > (rectangleX + rectangleWidth)) || (pointY) < (rectangleY - rectangleHeight) || (pointY > rectangleY))
        {
            Console.WriteLine("The chosen point with coordinates ({0},{1})\nis out of rectangle R(top-left({2},{3}), w{4}, h{5})\n", pointX, pointY, rectangleX, rectangleY, rectangleWidth, rectangleHeight);
        }
        else
        {
            Console.WriteLine("The chosen point with coordinates ({0},{1})\nis in of rectangle R(top-left({2},{3}), w{4}, h{5})\n", pointX, pointY, rectangleX, rectangleY, rectangleWidth, rectangleHeight);
        }
    }
}