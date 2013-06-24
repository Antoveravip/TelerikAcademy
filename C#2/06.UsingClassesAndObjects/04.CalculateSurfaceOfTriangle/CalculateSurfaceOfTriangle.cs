/* Lesson 6 - Using Classes and Objects
 * Homework 4
 * 
 * Write methods that calculate the 
 * surface of a triangle by given:
 * Side and an altitude to it; 
 * Three sides;
 * Two sides and an angle between them.
 * Use System.Math.
 */

using System;

class CalculateSurfaceOfTriangle
{
    public static double surface;

    static void Main()
    {
        bool check = false;
        Console.WriteLine("Please choice how you want to calculate the area of triangle?");
        Console.WriteLine("1. By side and altitude.\n2. By three sides\n3. Two sides and an angle between them.");
        while (check != true)
        {
            byte choice = byte.Parse(Console.ReadLine());
            check = choice == 1 || choice == 2 || choice == 3;
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter side b = ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter altitude h = ");
                        double h = double.Parse(Console.ReadLine());
                        CalculateTriangleSurface(b, h);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter side a = ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter side b = ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter side c = ");
                        double c = double.Parse(Console.ReadLine());
                        CalculateTriangleSurface(a, b, c);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter side a = ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter side b = ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter an angle = ");
                        double angle = double.Parse(Console.ReadLine());
                        double pi = Math.PI;
                        CalculateTriangleSurface(a, b, angle, pi);
                        break;
                    }
                default: { Console.WriteLine("Enter correct number!"); break; }
            }
        }
        Console.WriteLine("The surface of triangle is {0}", surface);
    }

    static double CalculateTriangleSurface(double b, double h)
    {
        surface = (b * h) / 2;
        return surface;
    }

    static double CalculateTriangleSurface(double a, double b, double c)
    {
        double halfPerimeter = (a + b + c) / 2;
        surface = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return surface;
    }

    static double CalculateTriangleSurface(double a, double b, double angle, double pi)
    {
        surface = (a * b * Math.Sin(pi * angle / 180)) / 2;
        return surface;
    }
}