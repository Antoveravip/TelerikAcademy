/* Lesson 6 - Loops
 * Homework 7
 * Write a program that reads a number N and calculates the sum of the first N members
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
 */

using System;

class SumOfFirstNFibonacciMembers
{
    static void Main()
    {
        uint members = 0;
        decimal fibonacciFirstMem, fibonacciSecMem, fibonacciNextMem, sum;

        // Input how many members of the sequence want to sum
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Enter first members of the sequence of Fibonacci you want to sum. N=");
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out members);
            if (check == false || inputData == "0")
            {
                check = false;
            }
            else
            {
                check = true;
                members = uint.Parse(inputData);
            }
        }
        //Calculates the sum of the first N members of the sequence of Fibonacci
        fibonacciFirstMem = 0;
        fibonacciSecMem = 1;
        if (members == 1)
        {
            sum = fibonacciFirstMem;
            Console.WriteLine("The sum of first {0} member is {1}", members, sum);
        }
        if (members == 2)
        {
            sum = fibonacciFirstMem + fibonacciSecMem;
            Console.WriteLine("The sum of first {0} members is {1}", members, sum);
        }
        if (members > 2)
        {
            sum = fibonacciFirstMem + fibonacciSecMem;
            for (int i = 3; i <= members; i++)
            {
                fibonacciNextMem = fibonacciFirstMem + fibonacciSecMem;
                sum = sum + fibonacciNextMem;
                fibonacciFirstMem = fibonacciSecMem;
                fibonacciSecMem = fibonacciNextMem;
            }
            Console.WriteLine("The sum of first {0} members is {1}", members, sum);
        }
    }
}