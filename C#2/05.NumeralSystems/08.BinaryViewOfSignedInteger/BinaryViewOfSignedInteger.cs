/* Lesson 5 - Numeral Systems
 * Homework 8
 * 
 * Write a program that shows the binary representation 
 * of given 16-bit signed integer number (the C# type short).
 */

using System;

class BinaryViewOfSignedInteger
{
    static void Main()
    {
        Console.Write("Enter 16-bit signed integer number: ");
        short integerNumber = short.Parse(Console.ReadLine());

        string binaryNumber = "";
        int remainder = 1, number = integerNumber;

        if (integerNumber < 0)
        {
            number = (integerNumber + 1) * (-1);
        }
        while (number != 0)
        {
            remainder = number % 2;
            number /= 2;
            binaryNumber = remainder + binaryNumber;
        }
        if (integerNumber >= 0)
        {
            binaryNumber = new string('0', 16 - binaryNumber.Length) + binaryNumber;
        }
        else
        {
            string binary = binaryNumber;
            binaryNumber = "";
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if ((binary[i] == '0'))
                {
                    binaryNumber = '1' + binaryNumber;
                }
                if (binary[i] == '1')
                {
                    binaryNumber = '0' + binaryNumber;
                }
            }
            binaryNumber = new string('1', 16 - binaryNumber.Length) + binaryNumber;
        }
        Console.WriteLine("The binary representation of decimal number {0} is {1}.", integerNumber, binaryNumber);
    }
}