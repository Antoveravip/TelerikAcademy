/* Lesson 9 - Strings and Text Processing
 * Homework 17
 * 
 * Write a program that reads a date and time given in 
 * the format: day.month.year hour:minute:second and 
 * prints the date and time after 6 hours and 30 minutes 
 * (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;

class PrintModifyTime
{
    static void Main()
    {
        //Test date
        //string inputDate = "16.03.2012 18:30:00";
        //DateTime enteredDate = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);        

        bool emptyDate = true;
        while (emptyDate != false)
        {
            try
            {
                Console.Write("Enter date in format (10.12.2006 16:00:00): ");
                string inputDate = Console.ReadLine();
                DateTime enteredDate = DateTime.ParseExact(inputDate, "d.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
                enteredDate = enteredDate.AddHours(6.5);
                Console.WriteLine("{0} - {1}", enteredDate, enteredDate.ToString("dddd", new CultureInfo("bg-BG")));
                emptyDate = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct format. Please enter the dates in the correct format 31.12.2012!\nMake sure that such a date exists!"); ;
            }
        }
    }
}