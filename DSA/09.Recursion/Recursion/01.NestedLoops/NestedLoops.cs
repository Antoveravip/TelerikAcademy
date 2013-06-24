/* Lesson 9 - Recursion
 * Homework 1
 * 
 * Write a recursive program that simulates the execution of n nested loops from 1 to n.
 * Examples: 
 *                            1 1 3
 *          1 1               1 2 1
 * n=2  ->  1 2      n=3  ->  ...
 *          2 1               3 2 3
 *          2 2               3 3 1
 *                            3 3 2
 *                            3 3 3  
 */

namespace _01.NestedLoops
{
    using System;

    public static class NestedLoops
    {
        public static void Main()
        {
            // Test data
            int n = 3;
  
            // Console input
            /*
            Console.WriteLine("Recursive program that simulates the execution of n nested loops from 1 to n!");
            Console.Write("Enter value for N = ");
            int n = int.Parse(Console.ReadLine());
            */
            int[] variationOfNumber = new int[n];
            Console.WriteLine("Variation:");
            Variation(variationOfNumber, 0, n);
        }

        public static void Variation(int[] variatedArray, int index, int number)
        {
            if (index == number)
            {
                ArrayOutput(variatedArray, number);
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    variatedArray[index] = i;
                    Variation(variatedArray, index + 1, number);
                }
            }
        }

        public static void ArrayOutput(int[] currentArray, int number)
        {            
            Console.Write("\n");
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0} ", currentArray[i]);
            }

            Console.Write('\b' + " " + '\n');
        }
    }
}