/* Lesson 2 - Arrays
 * Homework 15
 * 
 * Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
 */

using System;
using System.Collections.Generic;

class PrimeNumbersInArray
{
    static void Main()
    {
        int nums = 10000000;
        bool[] check = new bool[nums];
        for (int i = 0; i < nums; i++)
        {
            check[i] = true;
        }
        for (int value = 2; value < Math.Sqrt(nums); value++)
        {
            if (check[value] == true)
            {
                for (int prime = 2 * value; prime < nums; prime += value)
                {
                    if (prime % value == 0)
                    {
                        check[prime] = false;
                    }
                }
            }
        }
        /*
        //This code print all prime numbers from 1 to 10 000 000 - take some time!
        Console.WriteLine("The prime numbers in array from 1 to 10 000 000 are:");
        for (int print = 2; print < nums; print++)
        {
            if (check[print] == true)
            {
                Console.Write("{0}, ", print);
            }
        }
        */
    }
}