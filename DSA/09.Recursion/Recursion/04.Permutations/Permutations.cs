/* Lesson 9 - Recursion
 * Homework 4
 * 
 * Write a recursive program for generating and printing all permutations
 * of the numbers 1, 2, ..., n for given integer number n.
 * Example:
 *   
 * n=3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
 */

namespace _04.Permutations
{
    using System;

    public static class Permutations
    {
        public static void Main()
        {
            // Test data
            int n = 3;

            // Console input
            /*
            Console.WriteLine("Recursive program for generating and printing all permutations");
            Console.WriteLine("of the numbers 1, 2, ..., n for given integer number n.");
            Console.Write("Enter value for N = ");
            int n = int.Parse(Console.ReadLine());
            */
            int[] inputArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                inputArray[i] = i + 1;
            }

            Permutation(inputArray, 0, inputArray.Length - 1);
        }

        public static void Exchange(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        public static void Permutation(int[] currentArray, int current, int length)
        {
            if (current == length)
            {
                Console.Write("\n{");
                for (int i = 0; i <= length; i++)
                {
                    Console.Write(" {0},", currentArray[i]);
                }

                Console.Write('\b' + " }" + '\n');
            }
            else
            {
                for (int i = current; i <= length; i++)
                {
                    Exchange(ref currentArray[i], ref currentArray[current]);
                    Permutation(currentArray, current + 1, length);
                    Exchange(ref currentArray[i], ref currentArray[current]);
                }
            }
        }
    }
}