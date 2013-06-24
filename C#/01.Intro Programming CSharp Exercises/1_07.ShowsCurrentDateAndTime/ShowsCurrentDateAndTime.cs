/* Lesson 1 - Introduction to Programming
 * Homework 7
 * Create a console application that prints the current date and time.
 */

using System;

class ShowsCurrentDateAndTime
{
    static void Main()
    {
        DateTime current = DateTime.Now;
        Console.WriteLine(current);
    }
}