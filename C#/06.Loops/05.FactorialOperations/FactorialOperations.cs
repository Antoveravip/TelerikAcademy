/* Lesson 6 - Loops
 * Homework 5
 * Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
 */

using System;
using System.Numerics;

class FactorialOperations
{
    static BigInteger factorialDivision, factorialN = 1, factorialK = 1, factorialDiff = 1;
    static uint n, k, /*diff,*/ number, nNum, kNum;
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
        Console.Write("Enter N value for N!:");
        InputCheck();
        n = number;
        Console.Write("Enter K value for K!:");
        InputCheck();
        k = number;
        while (k <= n)
        {
            Console.Write("Not correct value for K! (K must be bigger than N.)\nTry again:");
            InputCheck();
            k = number;
        }
        //One way calculating all factorials
        /*diff = k - n;
         do
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
         do
         {
             factorialDiff *= diff;
             diff--;
         }
         while (diff > 0);
         factorialDivision = factorialN * (factorialK / factorialDiff);
         Console.WriteLine("The result of N!*K! / (K-N)! is: {0}", factorialDivision);*/

        //Another optimized way
        nNum = n;
        kNum = k;
        if ((k - n) == 1)
        {
            do
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
            factorialDivision = factorialN * factorialK;
            Console.WriteLine("The result of N!*K! / (K-N)! is: {0}", factorialDivision);
            n = nNum;
            k = kNum;
        }
        else
        {
            if (k == 2 * n)
            {
                do
                {
                    factorialK *= k;
                    k--;
                }
                while (k > 0);
                Console.WriteLine("The result of N!*K! / (K-N)! is: {0}", factorialK);
                k = kNum;
            }
            else
            {
                do
                {
                    factorialN *= n;
                    n--;
                }
                while (n > 0);
                n = nNum;
                for (uint i = (k - n + 1); i <= k; i++)
                {
                    factorialK *= i;
                }
                factorialDivision = factorialN * factorialK;
                Console.WriteLine("The result of N!*K! / (K-N)! is: {0}", factorialDivision);
            }
        }
    }
}