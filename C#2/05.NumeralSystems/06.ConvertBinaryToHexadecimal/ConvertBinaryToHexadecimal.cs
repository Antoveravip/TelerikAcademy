/* Lesson 5 - Numeral Systems
 * Homework 6
 * 
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;

class ConvertBinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        string hexadecimalNumber = "";

        if (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = new string('0', 4 - binaryNumber.Length % 4) + binaryNumber;
        }

        string fourCount = "";

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            fourCount = fourCount + binaryNumber[i];
            if (fourCount.Length == 4)
            {
                switch (fourCount)
                {
                    case "0000": { hexadecimalNumber = hexadecimalNumber + '0'; break; }
                    case "0001": { hexadecimalNumber = hexadecimalNumber + '1'; break; }
                    case "0010": { hexadecimalNumber = hexadecimalNumber + '2'; break; }
                    case "0011": { hexadecimalNumber = hexadecimalNumber + '3'; break; }
                    case "0100": { hexadecimalNumber = hexadecimalNumber + '4'; break; }
                    case "0101": { hexadecimalNumber = hexadecimalNumber + '5'; break; }
                    case "0110": { hexadecimalNumber = hexadecimalNumber + '6'; break; }
                    case "0111": { hexadecimalNumber = hexadecimalNumber + '7'; break; }
                    case "1000": { hexadecimalNumber = hexadecimalNumber + '8'; break; }
                    case "1001": { hexadecimalNumber = hexadecimalNumber + '9'; break; }
                    case "1010": { hexadecimalNumber = hexadecimalNumber + 'A'; break; }
                    case "1011": { hexadecimalNumber = hexadecimalNumber + 'B'; break; }
                    case "1100": { hexadecimalNumber = hexadecimalNumber + 'C'; break; }
                    case "1101": { hexadecimalNumber = hexadecimalNumber + 'D'; break; }
                    case "1110": { hexadecimalNumber = hexadecimalNumber + 'E'; break; }
                    case "1111": { hexadecimalNumber = hexadecimalNumber + 'F'; break; }
                    default: { break; }
                }
                fourCount = "";
            }
        }
        Console.WriteLine("The hexadecimal number of binary representation {0} is {1}.", binaryNumber, hexadecimalNumber);
    }
}