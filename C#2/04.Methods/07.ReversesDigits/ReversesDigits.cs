/* Lesson 4 - Methods
 * Homework 7
 * 
 * Write a method that reverses the digits of given decimal number.
 * 
 * Example: 256 --> 652
 */

using System;

class ReversesDigits
{
    static void Main()
    {
        Console.Write("Enter an number: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReversDigits(number);
        Console.WriteLine("Entered number {0} after revers is {1}", number, reversedNumber);
    }

    static int ReversDigits(int number)
    {
        int reversedNumber;
        string revers = "";
        while (number != 0)
        {
            revers += number % 10;
            number /= 10;
        }
        reversedNumber = int.Parse(revers);
        return reversedNumber;
    }
}