/* Lesson 5 - Conditional Statements
 * Homework 11*
 * Write a program that converts a number in the range [0...999]
 * to a text corresponding to its English pronunciation.
 * 
 * Examples:
 * 
 * 0 --> "Zero"
 * 273 --> "Two hundred seventy three"
 * 400 --> "Four hundred"
 * 501 --> "Five hundred and one"
 * 711 --> "Seven hundred and eleven"
 */

using System;

class ConvertsNumberToTextPronunciation
{
    static ushort number, numCase, tens, hundreds;
    static string inputData, outNum, tenStr, hundStr;

    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = ushort.TryParse(inputData, out number);
            if (check == false || inputData.Length >= 4 || number < 0)
            {
                check = false;
                Console.Write("Not correct digit! Please enter again:");
            }
            else
            {
                check = true;
                number = ushort.Parse(inputData);
            }
        }
    }

    static void DigitCheck()
    {
        switch (numCase)
        {
            case 1: { outNum = "One"; break; }
            case 2: { outNum = "Two"; break; }
            case 3: { outNum = "Three"; break; }
            case 4: { outNum = "Four"; break; }
            case 5: { outNum = "Five"; break; }
            case 6: { outNum = "Six"; break; }
            case 7: { outNum = "Seven"; break; }
            case 8: { outNum = "Eight"; break; }
            case 9: { outNum = "Nine"; break; }
            case 10: { outNum = "Ten"; break; }
            case 11: { outNum = "Eleven"; break; }
            case 12: { outNum = "Twelve"; break; }
            case 13: { outNum = "Thirteen"; break; }
            case 14: { outNum = "Fourteen"; break; }
            case 15: { outNum = "Fifteen"; break; }
            case 16: { outNum = "Sixteen"; break; }
            case 17: { outNum = "Seventeen"; break; }
            case 18: { outNum = "Eighteen"; break; }
            case 19: { outNum = "Nineteen"; break; }
            case 20: { outNum = "Twenty"; break; }
            case 30: { outNum = "Thirty"; break; }
            case 40: { outNum = "Forty"; break; }
            case 50: { outNum = "Fifty"; break; }
            case 80: { outNum = "Eighty"; break; }
            default: { outNum = ""; break; }
        }
    }

    static void Main()
    {
        Console.Write("Enter one positive number from 0 to 999:");
        InputCheck();
        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            tens = (ushort)(number % 100);
            hundreds = (ushort)(number / 100);
            if (tens != 0)
            {
                numCase = tens;
                DigitCheck();
                if (tens <= 10)
                {
                    numCase = tens;
                    DigitCheck();
                    tenStr = outNum;
                    numCase = 0;
                }
                else
                {
                    if (outNum != "")
                    {
                        tenStr = outNum;
                    }
                    if (outNum == "")
                    {
                        numCase = (ushort)(tens / 10);
                        if (numCase >= 2 && numCase <= 5 || numCase == 8)
                        {
                            numCase = (ushort)(numCase * 10);
                            DigitCheck();
                            tenStr = outNum + " ";
                        }
                        if (numCase == 6 || numCase == 7 || numCase == 9)
                        {
                            numCase = (ushort)(tens / 10);
                            DigitCheck();
                            tenStr = outNum + "ty ";
                        }
                        numCase = (ushort)(tens % 10);
                        DigitCheck();
                        tenStr = tenStr + outNum;
                    }
                }
            }
            if (hundreds != 0)
            {
                numCase = hundreds;
                DigitCheck();
                hundStr = outNum + " hundred";
                if (tens != 0)
                {
                    hundStr += " and ";
                }
                numCase = 0;
            }
            if (hundreds != 0 && tens != 0)
            {
                Console.WriteLine("{0}{1}", hundStr, tenStr.ToLower());
            }
            else
            {
                Console.WriteLine("{0}{1}", hundStr, tenStr);
            }
        }
    }
}