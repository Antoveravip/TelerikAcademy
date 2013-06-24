/* Lesson 9 - Recursion
 * Homework 2
 * 
 * Write a recursive program for generating and printing all the 
 * combinations with duplicates of k elements from n-element set. 
 * Example:
 * 
 * n=3, k=2 --> (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
 */

namespace _02.DuplicatedCombinations
{
    using System;

    public static class CombinationsWithDuplicates
    {
        public static void Main()
        {
            // Test data
            int n = 3;
            int k = 2;

            // Console input
            /*
            // Can do some checks for input and etc, but here we learn Recursion
            Console.WriteLine("Recursive program for generating and printing all the combinations with");
            Console.WriteLine("duplicates of k elements from n-element set");
            Console.Write("Enter value for N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value for K = ");
            int k = int.Parse(Console.ReadLine());
            */
            int[] combinationOfK = new int[k];
            Console.WriteLine("Combinations with duplicates:");
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
                    Combination(combinArray, elementsN, elementsK, index + 1, i);
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