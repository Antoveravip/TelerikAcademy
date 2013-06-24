/* Lesson 9 - Recursion
 * Homework 7
 * 
 * We are given a matrix of passable and non-passable cells. 
 * Write a recursive program for finding all paths between 
 * two cells in the matrix.
 */

namespace _07.FindAllPatrhsInMatrix
{
    using System;

    public static class FindAllPatrhsInMatrix
    {
        private static string[,] labyrinth =
        {
            { " ", " ", " ", "*", " ", " ", " " },
            { "*", "*", " ", "*", " ", "*", " " },
            { " ", " ", " ", " ", " ", " ", " " },
            { " ", "*", "*", "*", "*", "*", " " },
            { " ", " ", " ", " ", " ", " ", " " },
        };

        private static int paths = 0;

        public static void Main()
        {
            SetExitPoint(4, 6);

            // Entry point coordinates
            int row = 0;
            int col = 0;
            
            FindPathToExit(row, col, 0);
            Console.WriteLine("There is {0} paths!", paths);
        }
        
        public static void FindPathToExit(int row, int col, int step)
        {
            // Out of range
            if (row < 0 || col < 0 || row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            // Exit string
            if (labyrinth[row, col] == "e")
            {
                Console.WriteLine("Exit found at [{0},{1}]", row, col);
                paths++;
                Console.WriteLine("This is path # {0} with {1} steps", paths, step);
                PrintLabyrint();
            }

            // Check for labirint wall
            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = step.ToString();
            step++;
            FindPathToExit(row, col - 1, step);
            FindPathToExit(row - 1, col, step);
            FindPathToExit(row, col + 1, step);
            FindPathToExit(row + 1, col, step);

            labyrinth[row, col] = " ";
        }

        public static void SetExitPoint(int row, int col)
        {
            labyrinth[row, col] = "e";
        }

        public static void PrintLabyrint()
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    Console.Write("{0, 2} ", labyrinth[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}