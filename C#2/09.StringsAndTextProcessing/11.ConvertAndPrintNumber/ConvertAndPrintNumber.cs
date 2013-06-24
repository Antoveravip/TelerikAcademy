/* Lesson 9 - Strings and Text Processing
 * Homework 11
 * 
 * Write a program that reads a number and prints
 * it as a decimal number, hexadecimal number,
 * percentage and in scientific notation. Format 
 * the output aligned right in 15 symbols.
 */

using System;

class ConvertAndPrintNumber
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D}", (int)number); // :D - Decimal format

        Console.WriteLine("{0,15:X}", (int)number); // :X - Hexadecimal format

        Console.WriteLine("{0,15:P}", number); // :P - Percentage format

        Console.WriteLine("{0,15:E}", number); // :E - Scientific notation 
    }
}