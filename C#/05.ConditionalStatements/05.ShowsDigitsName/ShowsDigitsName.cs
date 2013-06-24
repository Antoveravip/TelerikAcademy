/* Lesson 5 - Conditional Statements
 * Homework 5
 * Write program that asks for a digit and depending on the input shows
 * the name of that digit (in English) using a switch statement.
 */

using System;

class ShowsDigitsName
{
    static byte digit;
    static string inputData;

    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = byte.TryParse(inputData, out digit);
            if (check == false || inputData.Length > 1)
            {
                check = false;
                Console.Write("Not correct digit! Please enter again:");
            }
            else
            {
                check = true;
                digit = byte.Parse(inputData);
            }
        }
    }
    // Assigning input values and display that case.
    static void Main()
    {
        Console.Write("Enter a digit in the range [0..9]: ");
        InputCheck();
        switch (digit)
        {
            case 0: { Console.WriteLine("Zero"); break; }
            case 1: { Console.WriteLine("One"); break; }
            case 2: { Console.WriteLine("Two"); break; }
            case 3: { Console.WriteLine("Three"); break; }
            case 4: { Console.WriteLine("Four"); break; }
            case 5: { Console.WriteLine("Five"); break; }
            case 6: { Console.WriteLine("Six"); break; }
            case 7: { Console.WriteLine("Seven"); break; }
            case 8: { Console.WriteLine("Eight"); break; }
            case 9: { Console.WriteLine("Nine"); break; }
            default: { Console.WriteLine("Not correct digit sign!"); break; }
        }
    }
}