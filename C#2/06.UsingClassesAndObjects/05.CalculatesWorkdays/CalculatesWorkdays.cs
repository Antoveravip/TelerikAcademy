/* Lesson 6 - Using Classes and Objects
 * Homework 5
 * 
 * Write a method that calculates the number of
 * workdays between today and given date, passed
 * as parameter. Consider that workdays are all 
 * days from Monday to Friday except a fixed list
 * of public holidays specified preliminary as array.
 */

using System;

class CalculatesWorkdays
{
    public static void Main()
    {
        Console.WriteLine("Enter a end date in YYYY/MM/DD format");
        string[] endDateStr = Console.ReadLine().Split('/');
        int day = int.Parse(endDateStr[2]);
        int month = int.Parse(endDateStr[1]);
        int year = int.Parse(endDateStr[0]);

        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timePeriod = 0;
        timePeriod = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }

        DateTime[] holidays = { new DateTime(2011, 1, 2),
                                new DateTime(2011, 4, 16),
                                new DateTime(2011, 5, 1),
                                new DateTime(2011, 5, 25),
                                new DateTime(2011, 9, 7),
                                new DateTime(2011, 12, 24),
                                new DateTime(2011, 12, 25),
                                new DateTime(2011, 12, 26),                                
                                new DateTime(2012, 1, 2),
                                new DateTime(2012, 4, 30),
                                new DateTime(2012, 5, 24),
                                new DateTime(2012, 5, 25),
                                new DateTime(2012, 9, 7),
                                new DateTime(2012, 12, 24),
                                new DateTime(2012, 12, 25),
                                new DateTime(2012, 12, 26),  
                                new DateTime(2013, 1, 1),
                                new DateTime(2013, 1, 18),
                                new DateTime(2013, 5, 1),
                                new DateTime(2013, 5, 2),
                                new DateTime(2013, 5, 3)
        };
        Console.WriteLine("All days in this period are {0}", timePeriod);
        int countWorkDays = 0;
        bool isHoliday = false;

        // Day checker
        for (int i = 0; i < timePeriod; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    countWorkDays++;
                }

                isHoliday = false;
            }
        }
        Console.WriteLine("Working days in this period was {0}", countWorkDays);
    }
}