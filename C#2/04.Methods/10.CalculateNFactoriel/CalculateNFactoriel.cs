/* Lesson 4 - Methods
 * Homework 10
 * 
 * Write a program to calculate n! for each n 
 * in the range [1..100]. Hint: Implement first
 * a method that multiplies a number represented
 * as array of digits by given integer number.
 */

using System;
using System.Numerics;

class CalculateNFactoriel
{
    static void Main()
    {
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        CalculateEnFactorial(array);
    }

    static void CalculateEnFactorial(int[] array)
    {
        BigInteger factorial = 0;
        for (int n = 0; n < array.Length; n++)
        {
            factorial = EnFactorial(n);
        }
        //If want to see the value
        //Console.WriteLine(factorial);
    }

    static BigInteger EnFactorial(int n)
    {
        BigInteger factorial = n;
        while (n > 0)
        {
            factorial *= n;
            n--;
        }
        return factorial;
    }
}