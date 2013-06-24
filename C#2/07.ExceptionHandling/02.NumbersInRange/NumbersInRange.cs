/* Lesson 7 - Exception Handling
 * Homework 2
 * 
 * Write a method ReadNumber(int start, int end) that enters an integer
 * number in given range [start…end]. If an invalid number or non-number
 * text is entered, the method should throw an exception. Using this 
 * method write a program that enters 10 numbers: a1, a2, … a10, 
 * such that 1 < a1 < … < a10 < 100
 */

using System;

class NumbersInRange
{
    static void Main()
    {
        //Test start, end values
        int start = 0, end = 100, count = 10;

        /*
        Console.Write("Enter lower boundary start = ");
        int start = ReadParameters();
        Console.Write("Enter upper boundary end = ");
        int end = ReadParameters();
        Console.Write("Enter how many numbers want to check = ");
        int count = ReadParameters();
        */

        for (int i = 1; i <= count; i++)
        {
            start = ReadNumber(start, end);
        }

    }

    public static int ReadNumber(int start, int end)
    {
        int inputNumber = 0;

        try
        {
            Console.Write("Enter an number between {0} and {1}: ", start, end);
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < start || inputNumber > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is not valid number!");
            return start;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Entered number is not in the possible range!");
            return start;
        }
        return inputNumber;
    }

    public static int ReadParameters()
    {
        int value = 0;
        try
        {
            value = int.Parse(Console.ReadLine());

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is not valid number!");
            return 0;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Entered number is not positive number!");
            return 0;
        }
        return value;
    }
}