/* Lesson 9 - Strings and Text Processing
 * Homework 16
 * 
 * Write a program that reads two dates in the format: day.month.year
 * and calculates the number of days between them. 
 * Example:
 * 
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days
 */

using System;
using System.Globalization;

class CalculateDays
{
    static void Main()
    {
        Console.WriteLine("Enter date in format day.month.year (31.12.2012)");
        bool emptyDate = true;
        while (emptyDate != false)
        {
            try
            {
                Console.Write("Enter the start date: ");
                string inputData = Console.ReadLine();
                DateTime startDate = DateTime.ParseExact(inputData, "d.MM.yyyy", CultureInfo.InvariantCulture);

                Console.Write("Enter the end date: ");
                inputData = Console.ReadLine();
                DateTime endDate = DateTime.ParseExact(inputData, "d.MM.yyyy", CultureInfo.InvariantCulture);

                double daysDifference = (endDate - startDate).TotalDays;
                if (daysDifference > 1)
                {
                    Console.WriteLine("Distance: {0} days", daysDifference);
                    emptyDate = false;
                }
                else
                {
                    Console.WriteLine("Distance: {0} day", daysDifference);
                    emptyDate = false;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct format. Please enter the dates in the correct format 31.12.2012!\nMake sure that such a date exists!"); ;
            }
        }
    }
}