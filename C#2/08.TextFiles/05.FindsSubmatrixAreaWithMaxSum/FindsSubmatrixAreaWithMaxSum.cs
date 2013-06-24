/* Lesson 9 - Text Files
 * Homework 5
 * 
 * Write a program that reads a text file containing a 
 * square matrix of numbers and finds in the matrix an
 * area of size 2 x 2 with a maximal sum of its elements.
 * The first line in the input file contains the size of
 * matrix N. Each of the next N lines contain N numbers
 * separated by space. The output should be a single number 
 * in a separate text file. 
 * Example:
 * 4
 * 2 3 3 4
 * 0 2 3 4	---> 17
 * 3 7 1 2
 * 4 3 3 2
 */

using System;
using System.IO;

class FindsSubmatrixAreaWithMaxSum
{
    static void Main()
    {
        int[,] matrix = ReadMatrixFromFile();

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the result
        //If want to see the submatrix
        /*
        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1}",
            matrix[bestRow, bestCol],
            matrix[bestRow, bestCol + 1]);
        Console.WriteLine("  {0} {1}",
            matrix[bestRow + 1, bestCol],
            matrix[bestRow + 1, bestCol + 1]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
        */
        Console.WriteLine("{0}", bestSum);
    }

    static int[,] ReadMatrixFromFile()
    {
        using (StreamReader input = new StreamReader("../../inputData.txt"))
        {
            int dim = int.Parse(input.ReadLine());
            int[,] matrix = new int[dim, dim];

            for (int i = 0; i < dim; i++)
            {
                string[] numbers = input.ReadLine().Split(' ');

                for (int j = 0; j < dim; j++)
                    matrix[i, j] = int.Parse(numbers[j]);
            }
            return matrix;
        }
    }
}