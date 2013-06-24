/* Lesson 6 - Using Classes and Objects
 * Homework 3
 * 
 * Write a program that prints to the console which
 * day of the week is today. Use System.DateTime.
 */

using System;

class PrintsDayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}