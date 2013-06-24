/* Lesson 6 - Loops
 * Homework 9
 * In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
 * Cn = (2*n)! / (n+1)!*n!
 */

using System;
using System.Numerics;

class TheCatalanNumbers
{
    static BigInteger catalanNumber, factorialN = 1, factorialK = 1, factorialSum = 1;
    static uint n, k, number, numberN, numberK/*, sum*/;
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
            if (check == false)
            {
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
        Console.Write("Enter value for N=");
        InputCheck();
        n = number;
        k = 2 * n;
        //One way calculating all factorials
        /*sum = n + 1;
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
             factorialSum *= sum;
             sum--;
         }
         while (sum > 0);
         catalanNumber = factorialK / (factorialSum * factorialN);
         Console.WriteLine("The {0}th catalan number by formyla\nCn = 2n! / (n-1)!*n! is: {0}", numberN, catalanNumber);*/

        //Another optimized way
        numberN = n;
        numberK = k;
        if (n == 0)
        {
            catalanNumber = 1;
            Console.WriteLine("The {0} catalan number by formula\nCn = (2*n)! / (n+1)!*n! is: {1}", numberN, catalanNumber);
        }
        else
        {
            do
            {
                factorialN *= n;
                n--;
            }
            while (n > 0);
            n = numberN;
            for (uint i = (n + 2); i <= 2 * n; i++)
            {
                factorialK *= i;
            }
            catalanNumber = factorialK / factorialN;
            Console.WriteLine("The {0} catalan number by formula\nCn = (2*n)! / (n+1)!*n! is: {1}", numberN, catalanNumber);
        }
    }
}