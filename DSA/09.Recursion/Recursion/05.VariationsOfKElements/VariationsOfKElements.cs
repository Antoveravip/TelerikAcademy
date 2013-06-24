/* Lesson 9 - Recursion
 * Homework 5
 * 
 * Write a recursive program for generating and printing all 
 * ordered k-element subsets from n-element set (variations Vkn).
 * Example:
 * n=3, k=2, set = {hi, a, b} =>
 * (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
 */

namespace _05.VariationsOfKElements
{
    using System;

    public static class VariationsOfKElements
    {
        // To avoid so much parameters in functions we can get out as static parameters the most of the parameters.
        // static int n = Console.ReadLine(); etc. 
        public static void Main()
        {
            // Test data
            int n = 3;
            int k = 2;
            string[] set = { "hi", "a", "b" };

            // Console input
            /*
            Console.WriteLine("Recursive program for generating and printing all ordered k-element subsets");
            Console.WriteLine("from n-element set (variations Vkn)");
            Console.Write("Enter value for N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value for K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter words separated with ',' for set = ");
            string input = Console.ReadLine().Replace(" ", "");
            string[] set = input.Split(',');
            */

            string[] variationOfK = new string[k];
            Variation(variationOfK, 0, n, k, set);
        }

        public static void Variation(string[] variatedArray, int index, int elementN, int elementK, string[] set)
        {
            if (index == elementK)
            {
                ArrayOutput(variatedArray, elementK);
            }
            else
            {
                for (int i = 0; i < elementN; i++)
                {
                    variatedArray[index] = set[i];
                    Variation(variatedArray, index + 1, elementN, elementK, set);
                }
            }
        }

        public static void ArrayOutput(string[] currentArray, int elementK)
        {
            Console.Write("\n{");
            for (int i = 0; i < elementK; i++)
            {
                Console.Write("{0} ", currentArray[i]);
            }

            Console.Write('\b' + "}" + '\n');
        }
    }
}