/* Lesson 4 - Console Input Output
 * Homework 9
 * Write a program to print the first 100 members of the sequence of
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */

using System;

class PrintFirstEnMembersOfFibonaccisSequence
{
    static void Main()
    {
        uint members = 100;
        decimal fibonacciFirstMem, fibonacciSecMem, fibonacciNextMem;
        /*
        // This code allow to input how many members of the sequence want to print
        string inputData;
        bool check = false;
        while (check != true)
        {
            Console.Write("Enter how many members of the sequence of Fibonacci you want to print:");
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
        } */

        //This code start printing the wanted members of the sequence.
        //Without upper code - will print by default first 100 members.
        Console.Write("\nThe first {0} members is of the sequence of Fibonacci are:\n", members);
        fibonacciFirstMem = 0;
        fibonacciSecMem = 1;
        if (members == 1)
        {
            Console.WriteLine("| {0} | {1}\n", members, fibonacciFirstMem);
        }
        if (members == 2)
        {
            Console.WriteLine("| {0} | {1}\n| {0} | {2}\n", members, fibonacciFirstMem, fibonacciSecMem);
        }
        if (members > 2)
        {
            Console.WriteLine(new string('-', 31));
            Console.WriteLine("|   1 | {0} |", fibonacciFirstMem.ToString().PadLeft(21));
            Console.WriteLine(new string('-', 31));
            Console.WriteLine("|   2 | {0} |", fibonacciSecMem.ToString().PadLeft(21));
            Console.WriteLine(new string('-', 31));
            for (int k = 3; k <= members; k++)
            {
                fibonacciNextMem = fibonacciFirstMem + fibonacciSecMem;
                fibonacciFirstMem = fibonacciSecMem;
                fibonacciSecMem = fibonacciNextMem;
                Console.WriteLine("| {0} | {1} |", k.ToString().PadLeft(3), fibonacciNextMem.ToString().PadLeft(21));
                Console.WriteLine(new string('-', 31));
            }
        }
    }
}