/* Lesson 5 - Numeral Systems
 * Homework 4
 * 
 * Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;

class ConvertHexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimalNumber = Console.ReadLine();
        int length = hexadecimalNumber.Length;
        int decimalNumber = 0;

        foreach (char ch in hexadecimalNumber)
        {
            length--;
            if (ch >= '0' && ch <= '9')
            {
                decimalNumber += (ch - '0') * (int)Math.Pow((double)16, length);
            }
            else
            {
                decimalNumber += (ch - 'A' + 10) * (int)Math.Pow((double)16, length);
            }
        }
        Console.WriteLine("The hexadecimal number {0} is decimal number {1}.", hexadecimalNumber, decimalNumber);
    }
}