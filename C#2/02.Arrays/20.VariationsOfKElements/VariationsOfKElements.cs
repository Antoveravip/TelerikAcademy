/* Lesson 2 - Arrays
 * Homework 20
 * 
 * Write a program that reads two numbers N and K
 * and generates all the variations of K elements 
 * from the set [1..N].
 * 
 * Example:
 * N = 3, K = 2 --> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
 */

using System;

class VariationsOfKElements
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[] variationOfK = new int[k];
        Variation(variationOfK, 0);
    }

    public static void Variation(int[] variatedArray, int index)
    {
        if (index == k)
        {
            ArrayOutput(variatedArray);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                variatedArray[index] = i;
                Variation(variatedArray, index + 1);
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