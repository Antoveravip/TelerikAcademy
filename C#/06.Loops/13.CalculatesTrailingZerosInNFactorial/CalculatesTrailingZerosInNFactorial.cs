/* Lesson 6 - Loops
 * Homework 13 *
 * Write a program that calculates for given N how many trailing
 * zeros present at the end of the number N!.
 * 
 * Examples:
 * N = 10 --> N! = 3628800 --> 2
 * N = 20 --> N! = 2432902008176640000 --> 4
 * 
 * Does your program work for N = 50 000?
 * 
 * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5.
 * Think why!
 */

using System;
using System.Numerics;

class CalculatesTrailingZerosInNFactorial
{
    static BigInteger n, number, zeros, member, powerFive = 1;
    static string inputData;
    static bool check = false;

    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = BigInteger.TryParse(inputData, out number);
            if (check == false || number <= 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = BigInteger.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter value for N!. N=");
        InputCheck();
        n = number;
        //The number of trailing zeros in the decimal representation of n!,
        //the factorial of a non-negative integer n, is simply the multiplicity
        //of the prime factor 5 in n!. This can be determined with this special case of de Polignac's formula:
        //F(n)=Sum(i = 1 to k) n / 5 ^ i where k must be chosen such that 5 ^ (k+1) > n >= 5 ^ k
        do
        {
            powerFive *= 5;
            member = n / powerFive;
            zeros = zeros + member;
        }
        while (member != 0);
        Console.WriteLine("Number of trailing zeros present at the end of the number N! is {0}", zeros);
    }
}