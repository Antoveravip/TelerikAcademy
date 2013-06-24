/* Lesson 9 - Recursion
 * Homework 3
 * 
 * Modify the previous program to skip duplicates:
 * Example:
 * 
 * n=4, k=2 --> (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
 */

namespace _03.Combinations
{
    using System;

    public static class Combinations
    {
        public static void Main()
        {
            // Test data
            int n = 4;
            int k = 2;

            // Console input
            /*
            // Can do some checks for input and etc, but here we learn Recursion
            Console.WriteLine("Recursive program for generating and printing all the combinations without");
            Console.WriteLine("duplicates of k elements from n-element set");
            Console.Write("Enter value for N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value for K = ");
            int k = int.Parse(Console.ReadLine());
            */
            int[] combinationOfK = new int[k];
            Console.WriteLine("Combinations without duplicates:");
            Combination(combinationOfK, n, k, 0, 1);
        }

        public static void Combination(int[] combinArray, int elementsN, int elementsK, int index, int currentValue)
        {
            if (index == elementsK)
            {
                ArrayOutput(combinArray, elementsK);
            }
            else
            {
                for (int i = currentValue; i <= elementsN; i++)
                {
                    combinArray[index] = i;

                    // Only here by adding 1 to i we avoid the duplicates
                    Combination(combinArray, elementsN, elementsK, index + 1, i + 1);
                }
            }
        }

        public static void ArrayOutput(int[] currentArray, int elementsK)
        {
            Console.Write("\n{");
            for (int i = 0; i < elementsK; i++)
            {
                Console.Write(" {0},", currentArray[i]);
            }

            Console.Write('\b' + " }" + '\n');
        }
    }
}