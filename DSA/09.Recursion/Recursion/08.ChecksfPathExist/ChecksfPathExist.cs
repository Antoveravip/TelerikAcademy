/* Lesson 9 - Recursion
 * Homework 8
 * 
 * Modify the above program to check whether a path exists 
 * between two cells without finding all possible paths.
 * Test it over an empty 100 x 100 matrix.
 */

namespace _08.ChecksfPathExist
{
    using System;

    public static class ChecksfPathExist
    {
        private static bool extiFound = false;

        public static void Main()
        {
            // Entry point coordinates
            int row = 0;
            int col = 0;

            string[,] emptyMatrix = CreateEmptyMatrix(100, 100);

            SetExitPoint(emptyMatrix, 90, 99);
            FindPathToExit(emptyMatrix, row, col, 0);            
        }

        public static void FindPathToExit(string[,] matrix, int row, int col, int step)
        {
            // Out of range
            if (extiFound || row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return;
            }

            // Exit string
            if (matrix[row, col] == "e")
            {
                // PrintMatrix(matrix);
                extiFound = true;
                Console.WriteLine("Exit found at [{0},{1}] after {2} steps!", row, col, step);
            }

            // Check for labirint wall
            if (matrix[row, col] != " ")
            {
                return;
            }

            matrix[row, col] = step.ToString();
            step++;

            FindPathToExit(matrix, row, col - 1, step);
            FindPathToExit(matrix, row - 1, col, step);
            FindPathToExit(matrix, row, col + 1, step);
            FindPathToExit(matrix, row + 1, col, step);

            matrix[row, col] = " ";
        }

        public static void SetExitPoint(string[,] matrix, int row, int col)
        {
            matrix[row, col] = "e";
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 2} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static string[,] CreateEmptyMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = " ";
                }
            }

            return matrix;
        }
    }
}