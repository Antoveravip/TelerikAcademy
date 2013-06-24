/* Lesson 5 - Numeral Systems
 * Homework 3
 * 
 * Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;

class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        string hexadecimalNumber = "";
        int remainder = 1, number = decimalNumber;

        while (number != 0)
        {
            remainder = number % 16;
            number /= 16;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10: { hexadecimalNumber = "A" + hexadecimalNumber; break; }
                    case 11: { hexadecimalNumber = "B" + hexadecimalNumber; break; }
                    case 12: { hexadecimalNumber = "C" + hexadecimalNumber; break; }
                    case 13: { hexadecimalNumber = "D" + hexadecimalNumber; break; }
                    case 14: { hexadecimalNumber = "E" + hexadecimalNumber; break; }
                    case 15: { hexadecimalNumber = "F" + hexadecimalNumber; break; }
                    default: { break; }                        
                }
            }
            else
            {
                hexadecimalNumber = remainder + hexadecimalNumber;
            }            
        }
        Console.WriteLine("The decimal number {0} is hexadecimal number {1}.", decimalNumber, hexadecimalNumber);
    }
}