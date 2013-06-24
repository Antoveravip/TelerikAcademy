/* Lesson 2 - Primitive Data Types and Variables
 * Homework 8
 * Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings.
 */

using System;

class StringQuotations
{
    static void Main()
    {
        string usualWay;
        usualWay = "The use of quotations causes difficulties.";
        Console.WriteLine(usualWay);
        string firstWay;
        firstWay = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstWay);
        string secWay;
        secWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(secWay);
    }
}