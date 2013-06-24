/* Lesson 6 - Loops
 * Homework 4
 * Write a program that calculates N!/K! for given N and K (1<K<N).
 */

using System;
using System.Numerics;

class FactorialDivision
{
    static BigInteger factorialDivision, factorialN = 1, factorialK = 1;
    static uint n, k, number;
    static string inputData;
    static bool check = false;

    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out number);
            if (check == false || inputData == "0" || inputData == "1")
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = uint.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter K value for K!:");
        InputCheck();
        k = number;
        Console.Write("Enter N value for N!:");
        InputCheck();
        n = number;
        while (n <= k)
        {
            Console.Write("Not correct value for N! (N must be bigger than K.)\nTry again:");
            InputCheck();
            n = number;
        }
        //One way using factorial division
        /* do
        {
            factorialN *= n;
            n--;
        }
        while (n > 0);
        do
        {
            factorialK *= k;
            k--;
        }
        while (k > 0);
        factorialDivision = factorialN / factorialK;
        Console.WriteLine("The result of N!/K! is: {0}", factorialDivision);*/

        //We can find this result and with product of K+1 and numbers to N - without using so many factorials!
        factorialDivision = 1;
        do
        {
            factorialDivision *= n;
            n--;
        }
        while (n > k);
        Console.WriteLine("The result of N!/K! is: {0}", factorialDivision);
    }
}