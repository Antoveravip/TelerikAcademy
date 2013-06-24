/* Lesson 5 - Numeral Systems
 * Homework 7
 * 
 * Write a program to convert from any numeral system of
 * given base s to any other numeral system of base d 
 * (2 ≤ s, d ≤  16).
 */

using System;

class NumberConvertor
{
    public static void Main()
    {
        byte s = 0, d = 0;
        do
        {
            Console.Write("Please choose the base of numeral system to convert (2, 8, 10, 16): ");
            s = byte.Parse(Console.ReadLine());
        }
        while ((s != 2) && (s != 8) && (s != 10) && (s != 16));

        do
        {
            Console.Write("Please choose the base to which numeral system to convert (2, 8, 10, 16): ");
            d = byte.Parse(Console.ReadLine());
        }
        while (d == s && ((d != 2) && (d != 8) && (d !=10) && (d != 16)));
        
        if (s == 2)
        {
            if (d == 8)  { BinaryToOctal(); }
            if (d == 10) { BinaryToDecimal(); }
            if (d == 16) { BinaryToHexadecimal(); }
        }
        if (s == 8)
        {
            if (d == 2)  { OctalToBinary(); }
            if (d == 10) { OctalToDecimal(); }
            if (d == 16) { OctalToHexadecimal(); }
        }
        if (s == 10)
        {
            if (d == 2)  { DecimalToBinary(); }
            if (d == 8)  { DecimalToOctal(); }
            if (d == 16) { DecimalToHexadecimal(); }
        }
        if (s == 16)
        {
            if (d == 2)  { HexadecimalToBinary(); }
            if (d == 8)  { HexadecimalToOctal(); }
            if (d == 10) { HexadecimalToDecimal(); }
        }
    }

    public static void BinaryToOctal()
    {
        string binaryNumber = Console.ReadLine();

        string octalNumber = "";

        if (binaryNumber.Length % 3 != 0)
        {
            binaryNumber = new string('0', 3 - binaryNumber.Length % 3) + binaryNumber;
        }

        string threeCount = "";

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            threeCount = threeCount + binaryNumber[i];
            if (threeCount.Length == 3)
            {
                switch (threeCount)
                {
                    case "000": { octalNumber = octalNumber + '0'; break; }
                    case "001": { octalNumber = octalNumber + '1'; break; }
                    case "010": { octalNumber = octalNumber + '2'; break; }
                    case "011": { octalNumber = octalNumber + '3'; break; }
                    case "100": { octalNumber = octalNumber + '4'; break; }
                    case "101": { octalNumber = octalNumber + '5'; break; }
                    case "110": { octalNumber = octalNumber + '6'; break; }
                    case "111": { octalNumber = octalNumber + '7'; break; }
                    default: { break; }
                }
                threeCount = "";
            }
        }
        Console.WriteLine("The octal number of binary representation {0} is {1}.", binaryNumber, octalNumber);
    }
    public static void BinaryToDecimal()
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
    public static void BinaryToHexadecimal()
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
    public static void OctalToBinary()
    {
        string octalNumber = Console.ReadLine();

        string binaryNumber = "";

        foreach (char ch in octalNumber)
        {
            switch (ch)
            {
                case '0': { binaryNumber = binaryNumber + "000"; break; }
                case '1': { binaryNumber = binaryNumber + "001"; break; }
                case '2': { binaryNumber = binaryNumber + "010"; break; }
                case '3': { binaryNumber = binaryNumber + "011"; break; }
                case '4': { binaryNumber = binaryNumber + "100"; break; }
                case '5': { binaryNumber = binaryNumber + "101"; break; }
                case '6': { binaryNumber = binaryNumber + "110"; break; }
                case '7': { binaryNumber = binaryNumber + "111"; break; }           
                default: { break; }
            }
        }
        Console.WriteLine("The binary representation of octal number {0} is {1}.", octalNumber, binaryNumber);
    }
    public static void OctalToDecimal()
    {
        string octalNumber = Console.ReadLine();
        int length = octalNumber.Length;
        int decimalNumber = 0;

        foreach (char ch in octalNumber)
        {
            length--;
            if (ch >= '0' && ch <= '7')
            {
                decimalNumber += (ch - '0') * (int)Math.Pow((double)8, length);
            }
        }
        Console.WriteLine("The octal number {0} is decimal number {1}.", octalNumber, decimalNumber);
    }
    public static void OctalToHexadecimal()
    {
        //In this convertion I use convert from octal to decimal to hexadecimal
        string octalNumber = Console.ReadLine();
        int length = octalNumber.Length;
        int decimalNumber = 0;

        foreach (char ch in octalNumber)
        {
            length--;
            if (ch >= '0' && ch <= '7')
            {
                decimalNumber += (ch - '0') * (int)Math.Pow((double)8, length);
            }
        }
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
        Console.WriteLine("The octal number {0} is hexadecimal number {1}.", octalNumber, hexadecimalNumber);
    }
    public static void DecimalToBinary()
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
    public static void DecimalToOctal()
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        string octalNumber = "";
        int remainder = 1, number = decimalNumber;

        while (number != 0)
        {
            remainder = number % 8;
            number /= 8;
            octalNumber = remainder + octalNumber;
        }
        Console.WriteLine("The decimal number {0} is octal number {1}.", decimalNumber, octalNumber);
    }
    public static void DecimalToHexadecimal()
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
    public static void HexadecimalToBinary()
    {
        string hexadecimalNumber = Console.ReadLine();

        string binaryNumber = "";

        foreach (char ch in hexadecimalNumber)
        {
            switch (ch)
            {
                case '0': { binaryNumber = binaryNumber + "0000"; break; }
                case '1': { binaryNumber = binaryNumber + "0001"; break; }
                case '2': { binaryNumber = binaryNumber + "0010"; break; }
                case '3': { binaryNumber = binaryNumber + "0011"; break; }
                case '4': { binaryNumber = binaryNumber + "0100"; break; }
                case '5': { binaryNumber = binaryNumber + "0101"; break; }
                case '6': { binaryNumber = binaryNumber + "0110"; break; }
                case '7': { binaryNumber = binaryNumber + "0111"; break; }
                case '8': { binaryNumber = binaryNumber + "1000"; break; }
                case '9': { binaryNumber = binaryNumber + "1001"; break; }
                case 'A': { binaryNumber = binaryNumber + "1010"; break; }
                case 'B': { binaryNumber = binaryNumber + "1011"; break; }
                case 'C': { binaryNumber = binaryNumber + "1100"; break; }
                case 'D': { binaryNumber = binaryNumber + "1101"; break; }
                case 'E': { binaryNumber = binaryNumber + "1110"; break; }
                case 'F': { binaryNumber = binaryNumber + "1111"; break; }
                default: { break; }
            }
        }
        Console.WriteLine("The binary representation of hexadecimal number {0} is {1}.", hexadecimalNumber, binaryNumber);
    }
    public static void HexadecimalToOctal()
    {
        //In this convertion I use convert from hexadecimal to binary to octal
        string hexadecimalNumber = Console.ReadLine();

        string binaryNumber = "";

        foreach (char ch in hexadecimalNumber)
        {
            switch (ch)
            {
                case '0': { binaryNumber = binaryNumber + "0000"; break; }
                case '1': { binaryNumber = binaryNumber + "0001"; break; }
                case '2': { binaryNumber = binaryNumber + "0010"; break; }
                case '3': { binaryNumber = binaryNumber + "0011"; break; }
                case '4': { binaryNumber = binaryNumber + "0100"; break; }
                case '5': { binaryNumber = binaryNumber + "0101"; break; }
                case '6': { binaryNumber = binaryNumber + "0110"; break; }
                case '7': { binaryNumber = binaryNumber + "0111"; break; }
                case '8': { binaryNumber = binaryNumber + "1000"; break; }
                case '9': { binaryNumber = binaryNumber + "1001"; break; }
                case 'A': { binaryNumber = binaryNumber + "1010"; break; }
                case 'B': { binaryNumber = binaryNumber + "1011"; break; }
                case 'C': { binaryNumber = binaryNumber + "1100"; break; }
                case 'D': { binaryNumber = binaryNumber + "1101"; break; }
                case 'E': { binaryNumber = binaryNumber + "1110"; break; }
                case 'F': { binaryNumber = binaryNumber + "1111"; break; }
                default: { break; }
            }
        }

        string octalNumber = "";

        if (binaryNumber.Length % 3 != 0)
        {
            binaryNumber = new string('0', 3 - binaryNumber.Length % 3) + binaryNumber;
        }

        string threeCount = "";

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            threeCount = threeCount + binaryNumber[i];
            if (threeCount.Length == 3)
            {
                if (i == 2 && threeCount == "000") { }
                else
                {
                    switch (threeCount)
                    {
                        case "000": { octalNumber = octalNumber + '0'; break; }
                        case "001": { octalNumber = octalNumber + '1'; break; }
                        case "010": { octalNumber = octalNumber + '2'; break; }
                        case "011": { octalNumber = octalNumber + '3'; break; }
                        case "100": { octalNumber = octalNumber + '4'; break; }
                        case "101": { octalNumber = octalNumber + '5'; break; }
                        case "110": { octalNumber = octalNumber + '6'; break; }
                        case "111": { octalNumber = octalNumber + '7'; break; }
                        default: { break; }
                    }
                }                
                threeCount = "";
            }
        }
        Console.WriteLine("The hexadecimal number {0} is octal number {1}.", hexadecimalNumber, octalNumber);
    }
    public static void HexadecimalToDecimal()
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