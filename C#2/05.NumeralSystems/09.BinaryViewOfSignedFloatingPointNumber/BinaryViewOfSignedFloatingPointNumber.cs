/* Lesson 5 - Numeral Systems
 * Homework 9*
 * 
 * Write a program that shows the internal binary representation
 * of given 32-bit signed floating-point number in IEEE 754 format
 * (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, 
 * mantissa = 10110100000000000000000.
 */

using System;

class BinaryViewOfSignedFloatingPointNumber
{
    static void Main()
    {
        Console.Write("Enter 32-bit floating point number: ");
        float number = Single.Parse(Console.ReadLine());

        string floatNumber = Represent(number);
        string binary = "";
        string binaryRepresent = "";

        for (int i = 0; i < floatNumber.Length; i++)
        {
            switch (floatNumber[i])
            {
                case '0': { binary += "0000"; break; }
                case '1': { binary += "0001"; break; }
                case '2': { binary += "0010"; break; }
                case '3': { binary += "0011"; break; }
                case '4': { binary += "0100"; break; }
                case '5': { binary += "0101"; break; }
                case '6': { binary += "0110"; break; }
                case '7': { binary += "0111"; break; }
                case '8': { binary += "1000"; break; }
                case '9': { binary += "1001"; break; }
                case 'A': { binary += "1010"; break; }
                case 'a': { binary += "1010"; break; }
                case 'B': { binary += "1011"; break; }
                case 'b': { binary += "1011"; break; }
                case 'C': { binary += "1100"; break; }
                case 'c': { binary += "1100"; break; }
                case 'D': { binary += "1101"; break; }
                case 'd': { binary += "1101"; break; }
                case 'E': { binary += "1110"; break; }
                case 'e': { binary += "1110"; break; }
                case 'F': { binary += "1111"; break; }
                case 'f': { binary += "1111"; break; }
                default: { break; }
            }

            for (int j = 0; j < binary.Length; j++)
            {
                if (i == floatNumber.Length - 1)
                {
                    binaryRepresent = binaryRepresent + binary[j];
                    if (j == 0 || j == 8)
                    {
                        binaryRepresent = binaryRepresent + " ";
                    }
                }
            }
            if (i == floatNumber.Length - 1)
            {
                Console.Write("Float Number: ");
                Console.WriteLine(binaryRepresent);
            }
        }
    }

    public static string Represent(float number)
    {
        byte[] array = BitConverter.GetBytes(number);
        Array.Reverse(array);
        string floatNumber = BitConverter.ToString(array);
        return floatNumber;
    }
}