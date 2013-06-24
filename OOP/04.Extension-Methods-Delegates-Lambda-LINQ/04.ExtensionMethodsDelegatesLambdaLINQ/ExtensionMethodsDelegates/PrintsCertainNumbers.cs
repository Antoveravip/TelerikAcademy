/* Home work task 6
 * 
 * Write a program that prints from given array of integers all numbers that
 * are divisible by 7 and 3. Use the built-in extension methods and lambda 
 * expressions. Rewrite the same with LINQ.
 */

using System;
using System.Linq;

namespace Timer
{
    class PrintsCertainNumbers
    {
        static void Main()
        {
            //Test int array
            int[] numbers = { 3, 7, 21, 42, 43, 210, 84, 14, 420, 840, 105, 10, 12, 14, 1, 5 };

            Console.WriteLine("Print all numbers that are divisible by 7 and 3:");

            //Find and print all numbers that are divisible by 7 and 3 with lambda expressions.
            Console.WriteLine("With lambda expressions: ");
            int[] twentyOne = numbers.Where(x => x % 21 == 0).ToArray();

            foreach (var number in twentyOne)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();

            //Find and print all numbers that are divisible by 7 and 3 with LINQ.
            Console.WriteLine("With LINQ: ");
            var queryTwentyOne =
                from number in numbers
                where number % 21 == 0
                select number;

            foreach (var number in queryTwentyOne)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();
        }
    }
}