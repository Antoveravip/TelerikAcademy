/* Lesson 9 - Recursion
 * Homework 10*
 * 
 * We are given a matrix of passable and non-passable cells. 
 * Write a recursive program for finding all areas of passable 
 * cells in the matrix.
 */

namespace _10.FindingAllAreas
{
    using System;

    public static class FindingOfAllAreas
    {
        private static string[,] labyrinth =
        {
            { " ", " ", " ", " ", " ", " ", " " },
            { "*", "*", "*", "*", "*", "*", "*" },
            { " ", " ", " ", " ", " ", " ", " " },
            { " ", "*", "*", "*", "*", "*", " " },
            { " ", " ", " ", " ", " ", " ", " " },
        };

        private static int rows = labyrinth.GetLength(0);
        private static int cols = labyrinth.GetLength(1);

        public static void Main()
        {
            FindAllAreas(rows, cols);
        }

        public static void FindAllAreas(int rows, int cols)
        {
            int step = 0, count = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (labyrinth[row, col] == " ")
                    {
                        FindArea(row, col, step, ref count);
                        PrintArea(step.ToString());
                        Console.WriteLine("The area with {0} has {1} length!", step, count);
                        count = 0;
                        step++;
                    }
                }
            }
        }

        public static void FindArea(int row, int col, int step, ref int count)
        {
            if (row < 0 || col < 0 || row >= rows || col >= cols)
            {
                return;
            }

            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = step.ToString();
            count++;

            FindArea(row, col - 1, step, ref count);
            FindArea(row - 1, col, step, ref count);
            FindArea(row, col + 1, step, ref count);
            FindArea(row + 1, col, step, ref count);
        }

        public static void PrintArea(string number)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (labyrinth[row, col] == number || labyrinth[row, col] == "*")
                    {
                        Console.Write("{0, 2} ", labyrinth[row, col]);
                    }
                    else
                    {
                        Console.Write("{0, 2} ", " ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}