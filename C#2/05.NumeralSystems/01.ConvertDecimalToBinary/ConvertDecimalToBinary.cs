/* Lesson 5 - Numeral Systems
 * Homework 1
 * 
 * Write a program to convert decimal numbers to their binary representation.
 */

using System;

class ConvertDecimalToBinary
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = "";
        int remainder = 1, number = decimalNumber;

        while (number != 0)
        {
            remainder = number % 2;
            number /= 2;
            binaryNumber = remainder + binaryNumber;
        }
        Console.WriteLine("The binary representation of decimal number {0} is {1}.", decimalNumber, binaryNumber);
    }
}