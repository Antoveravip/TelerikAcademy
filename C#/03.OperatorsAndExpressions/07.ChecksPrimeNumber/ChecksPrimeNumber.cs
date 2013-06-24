/* Lesson 3 - Operators and Expressions
 * Homework 7
 * Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
 * E.g. 37 is prime.
 */

using System;

class ChecksPrimeNumber
{
    static int n;
    // Check input data
    static void InputCheck()
    {
        string inputData;
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out n);
            if (check == false || n < 0 || n > 100)
            {
                check = false;
                Console.Write("Not correct value in range from 2 to 100! Please enter again:");
            }
            else
            {
                check = true;
                n = int.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        //Begin input, range and other checks
        Console.Write("Please enter positive integer below 100:");
        InputCheck();
        Console.WriteLine("You entered {0}.", n);
        //Begin the essential part of this programm
        int count = 2;
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(n); // Integer value of sqrt
        if (n >= 0 || n <= 2)
        {
            if (n == 0 || n == 1)
            {
                Console.WriteLine("This number is not prime and is not a composite!\n");
            }
            if (n == 2)
            {
                Console.WriteLine("This is the only even prime number!\n");
            }
        }
        if (n > 2)
        {
            do
            {
                for (divider = 2; divider <= maxDivider; divider++)
                {
                    if (n % divider == 0)
                    {
                        count++;
                    }
                }
            }
            while (divider <= maxDivider);
            if (count != 2)
            {
                Console.WriteLine("The entered positive integer {0} is not a prime number.\nThe number is composite number and have {1} dividers!", n, count);
            }
            else if (count == 2)
            {
                Console.WriteLine("The entered positive integer {0} is prime number\n", n);
            }
        }
    }
}