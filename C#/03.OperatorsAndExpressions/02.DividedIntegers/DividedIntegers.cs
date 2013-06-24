/* Lesson 3 - Operators and Expressions
 * Homework 2
 * Write a boolean expression that checks for given integer if it
 * can be divided (without remainder) by 7 and 5 in the same time.
 */

using System;

class DividedIntegers
{
    static int inputNumber;

    static void Main()
    {
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Please enter an integer /exept ziro/ to check if can be divided \nby 7 and 5 in same time:");
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out inputNumber);
            if (check = false || inputData.Length > 11 || inputNumber == 0)
            {
                check = false;
                Console.WriteLine("\nYou didn't enter correct integer number!");
            }
            else
            {
                check = true;
                inputNumber = int.Parse(inputData);
            }
        }
        //Boolean expression that checks for given integer if it can be divided (without remainder)
        //by 7 and 5 in the same time
        bool dividedCheck = (inputNumber % 5 == 0) && (inputNumber % 7 == 0);
        //Same way we can check this only with divided by 35 with one expression!
        //bool dividedCheck = (inputNumber % 35 == 0)
        // because 35 is the least common multiple of 5 and 7
        if (dividedCheck != true)
        {
            Console.WriteLine("The entered integer {0} can't be divided by 7 and 5 in same time", inputNumber);
            Console.WriteLine("Try again!\n ");
        }
        else
        {
            Console.WriteLine("\n\nThe entered number {0} can be divided by 7 and 5 in same time\n\n", inputNumber);
        }
    }
}