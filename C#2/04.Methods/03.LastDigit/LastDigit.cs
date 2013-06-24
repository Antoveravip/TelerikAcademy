/* Lesson 4 - Methods
 * Homework 3
 * 
 * Write a method that returns the last digit
 * of given integer as an English word.
 * 
 * Examples:
 * 512 --> "two",
 * 1024 --> "four",
 * 12309 --> "nine".
 */

using System;

class LastDigit
{
    static string GetLastDigit(int number)
    {
        int lastDigit = number % 10;
        string lastDigitName;
        switch (lastDigit)
        {
            case 1: { lastDigitName = "one"; break; }
            case 2: { lastDigitName = "two"; break; }
            case 3: { lastDigitName = "three"; break; }
            case 4: { lastDigitName = "four"; break; }
            case 5: { lastDigitName = "five"; break; }
            case 6: { lastDigitName = "six"; break; }
            case 7: { lastDigitName = "seven"; break; }
            case 8: { lastDigitName = "eight"; break; }
            case 9: { lastDigitName = "nine"; break; }
            default: { lastDigitName = ""; ; break; }
        }
        return lastDigitName;
    }

    static void Main()
    {
        Console.Write("Enter one number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        string lastDigitName = GetLastDigit(inputNumber);
        Console.WriteLine("The English word for last digit of entered number is \"{0}\"", lastDigitName);
    }
}