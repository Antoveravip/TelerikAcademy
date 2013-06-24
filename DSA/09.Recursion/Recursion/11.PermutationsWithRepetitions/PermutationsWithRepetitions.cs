/* Lesson 9 - Recursion
 * Homework 11*
 * 
 * Write a program to generate all permutations with repetitions of 
 * given multi-set. For example the multi-set {1, 3, 5, 5} has the 
 * following 12 unique permutations:
 * 
 * { 1, 3, 5, 5 }   { 1, 5, 3, 5 }
 * { 1, 5, 5, 3 }   { 3, 1, 5, 5 }
 * { 3, 5, 1, 5 }   { 3, 5, 5, 1 }
 * { 5, 1, 3, 5 }   { 5, 1, 5, 3 }
 * { 5, 3, 1, 5 }   { 5, 3, 5, 1 }
 * { 5, 5, 1, 3 }   { 5, 5, 3, 1 }
 * 
 * Ensure your program efficiently avoids duplicated permutations. 
 * Test it with { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
 * 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }.
 */

namespace _11.PermutationsWithRepetitions
{
    using System;

    public static class PermutationsWithRepetitions
    {
        public static void Main()
        {
            int[] set = { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            // int[] set = { 1, 3, 5, 5 };
            PermutationsWithRepetition(set);
        }

        public static void PermutationsWithRepetition(int[] set)
        {
            Array.Sort(set);
            Permute(set, 0, set.Length);
        }

        public static void Permute(int[] set, int start, int end)
        {
            PrintSet(set);

            int swap = 0;

            if (start < end)
            {
                for (int i = end - 2; i >= start; i--)
                {
                    for (int k = i + 1; k < end; k++)
                    {
                        if (set[i] != set[k])
                        {
                            swap = set[i];
                            set[i] = set[k];
                            set[k] = swap;

                            Permute(set, i + 1, end);
                        }
                    }

                    swap = set[i];
                    for (int k = i; k < end - 1; k++)
                    {
                        set[k] = set[k + 1];
                    }

                    set[end - 1] = swap;
                }
            }
        }

        public static void PrintSet(int[] set)
        {
            for (int index = 0; index < set.Length; index++)
            {
                Console.Write("{0} ", set[index]);
            }

            Console.WriteLine();
        }
    }
}