/* Lesson 6 - Using Classes and Objects
 * Homework 1
 * 
 * Write a program that reads a year from the console
 * and checks whether it is a leap. Use DateTime.
 */

using System;

class CheckForLeapYear
{
    static void Main()
    {
        Console.Write("Enter a year to check whether it is a leap: ");
        int inputYear = int.Parse(Console.ReadLine());
        bool isLeapYear = DateTime.IsLeapYear(inputYear);
        if (isLeapYear)
        {
            Console.WriteLine("Yes, the year {0} is leap.", inputYear);
        }
        else
        {
            Console.WriteLine("No, the year {0} is not leap.", inputYear);
        }
    }
}