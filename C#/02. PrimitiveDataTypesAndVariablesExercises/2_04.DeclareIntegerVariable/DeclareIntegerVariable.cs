/* Lesson 2 - Primitive Data Types and Variables
 * Homework 4
 * Declare an integer variable and assign it with the value 254 in hexadecimal format. 
 * Use Windows Calculator to find its hexadecimal representation.
 */

using System;

class DeclareIntegerVariable
{
    static void Main()
    {
        int valueInHex;
        valueInHex = 0xFE;
        Console.WriteLine("The assigned value is {0}", valueInHex);
        string hexValue = valueInHex.ToString("X");
        Console.WriteLine("The value {0} is {1} in hexadecimal format", valueInHex, hexValue);
        int reValueIn = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        int reValueInHex = Convert.ToInt32(hexValue, 16);
        Console.WriteLine("The reassigned value is {0} and {1} only!", reValueIn, reValueInHex);
    }
}