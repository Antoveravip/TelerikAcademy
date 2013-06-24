/* Lesson 2 - Arrays
 * Homework 21
 * 
 * Write a program that reads two numbers N and K
 * and generates all the combinations of K distinct
 * elements from the set [1..N].
 * 
 * Example:
 * N = 5, K = 2 --> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 */

using System;

class CombinationsOfK
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[] combinationOfK = new int[k];
        Combination(combinationOfK, 0, 1);
    }

    public static void Combination(int[] combinArray, int index, int currentValue)
    {
        if (index == k)
        {
            ArrayOutput(combinArray);
        }
        else
        {
            for (int i = currentValue; i <= n; i++)
            {
                combinArray[index] = i;
                Combination(combinArray, index + 1, i+1);
            }
        }
    }

    public static void ArrayOutput(int[] currentArray)
    {
        Console.Write("\n{");
        for (int i = 0; i < k; i++)
        {
            Console.Write(" {0},", currentArray[i]);
        }
        Console.Write('\b' + " }" + '\n');
    }
}