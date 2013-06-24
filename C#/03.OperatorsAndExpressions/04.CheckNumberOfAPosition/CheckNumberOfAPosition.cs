/* Lesson 3 - Operators and Expressions
 * Homework 4
 * Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 * E. g. 1732 --> true.
 */

using System;

class CheckNumberOfAPosition
{
    static int inputNumber;
    static bool check = false;
    static string inputData;

    static void Main()
    {
        Console.Write("Enter an integer number /3 digits or more/:");
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out inputNumber);
            if (check == false || inputData.Length < 3)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                inputNumber = int.Parse(inputData);
            }
        }
        int thirdPosition = inputNumber / 100;
        int remainder = thirdPosition % 10;
        if (remainder != 7)
        {
            Console.WriteLine("False! The number of third position is not seven. It is {0}", remainder);
        }
        else 
        {
            Console.WriteLine("True! The number ot third position is seven!");
        }
    }
}