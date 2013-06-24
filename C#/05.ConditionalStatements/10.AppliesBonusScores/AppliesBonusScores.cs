/* Lesson 5 - Conditional Statements
 * Homework 10
 * Write a program that applies bonus scores to given scores in the range [1..9].
 * The program reads a digit as an input. If the digit is between 1 and 3, the
 * program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
 * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value
 * is not a digit, the program must report an error.
 * Use a switch statement and at the end print the calculated new value in the console.
 */

using System;

class AppliesBonusScores
{
    static byte number;
    static ushort modNum;
    static string inputData;
    // Check input data
    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = byte.TryParse(inputData, out number);
            if (check == false)
            {
                Console.Write("Not correct digit! Please enter again:");
            }
            else
            {
                check = true;
                number = byte.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter one digit:");
        InputCheck();
        switch (number)
        {
            case 1:
            case 2:
            case 3:
                {
                    modNum = (ushort)(number * 10);
                    break;
                }
            case 4:
            case 5:
            case 6:
                {
                    modNum = (ushort)(number * 100);
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    modNum = (ushort)(number * 1000);
                    break;
                }
            default:
                {
                    Console.WriteLine("Error! Not correct digit! No bonus!");
                    modNum = 0;
                    break;
                }
        }
        if (modNum != 0)
        {
            Console.WriteLine("The entered digit {0} give you bonus scores {1} points", number, modNum);
        }
    }
}