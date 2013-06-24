/* Lesson 7 - Exception Handling
 * Homework 1
 * 
 * Write a program that reads an integer number and calculates
 * and prints its square root. If the number is invalid or
 * negative, print "Invalid number". In all cases finally print
 * "Good bye". Use try-catch-finally.
 */

using System;

class CalculateSquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            int inputNumber = Int32.Parse(str);
            Console.WriteLine("The square root is {0}", Sqrt(inputNumber));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    public static double Sqrt(double inputNumber)
    {
        if (inputNumber < 0)
        {
            throw new System.ArgumentOutOfRangeException(
                "Sqrt for negative numbers is undefined!");
        }
        double numberSqrt = Math.Sqrt(inputNumber);
        return numberSqrt;
    }
}