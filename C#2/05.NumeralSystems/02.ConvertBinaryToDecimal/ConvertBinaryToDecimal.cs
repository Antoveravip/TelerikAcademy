/* Lesson 5 - Numeral Systems
 * Homework 2
 * 
 * Write a program to convert binary numbers to their decimal representation.
 */

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        int length = binaryNumber.Length;
        int decimalNumber = 0;

        foreach (char ch in binaryNumber)
        {
            length--;
            decimalNumber += (ch - '0') * (int)Math.Pow((double)2, length);          
        }
        Console.WriteLine("The decimal number of binary representation {0} is {1}.", binaryNumber, decimalNumber);
    }
}