/* Lesson 9 - Recursion
 * Homework 6
 * 
 * Write a program for generating and printing all
 * subsets of k strings from given set of strings.
 * 
 * Example:
 * s = {test, rock, fun}, k=2 => 
 * (test rock),  (test fun),  (rock fun)
 */
namespace _06.SubsetsOfKElements
{
    using System;

    public static class SubsetsOfKElements
    {
        public static void Main()
        {
            // Test data
            int k = 3;
            string[] set = { "1", "-5", "7", "10", "-3" };

            // Console input
            /*
            Console.WriteLine("Recursive program for generating and printing all");
            Console.WriteLine("subsets of k strings from given set of strings");
            Console.Write("Enter value for K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter words separated with ',' for set = ");
            string input = Console.ReadLine().Replace(" ", "");
            string[] set = input.Split(',');
            */

            string[] combinationOfK = new string[k];
            Console.WriteLine("All subsets:");
            Combination(combinationOfK, k, 0, 0, set);
        }

        public static void Combination(string[] combinArray, int elementsK, int index, int currentValue, string[] set)
        {
            if (index == elementsK)
            {
                ArrayOutput(combinArray, elementsK);
            }
            else
            {
                for (int i = currentValue; i < set.Length; i++)
                {
                    combinArray[index] = set[i];

                    // Only here by adding 1 to i we avoid the duplicates
                    Combination(combinArray, elementsK, index + 1, i + 1, set);
                }
            }
        }

        public static void ArrayOutput(string[] currentArray, int elementsK)
        {
            Console.Write("\n(");
            for (int i = 0; i < elementsK; i++)
            {
                Console.Write("{0} ", currentArray[i]);
            }

            Console.Write('\b' + ")" + '\n');
        }
    }
}