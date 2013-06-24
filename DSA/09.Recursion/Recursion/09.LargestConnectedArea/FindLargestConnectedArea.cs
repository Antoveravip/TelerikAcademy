/* Lesson 9 - Recursion
 * Homework 9
 * 
 * Write a recursive program to find the largest 
 * connected area of adjacent empty cells in a matrix.
 */

namespace _09.LargestConnectedArea
{
    using System;

    public static class FindLargestConnectedArea
    {
        private static string[,] labyrinth =
        {
            { " ", " ", " ", "*", " ", " ", " " },
            { "*", "*", " ", "*", " ", "*", " " },
            { " ", " ", " ", " ", " ", " ", " " },
            { " ", "*", "*", "*", "*", "*", " " },
            { " ", " ", " ", " ", " ", " ", " " },
        };

        private static int rows = labyrinth.GetLength(0);
        private static int cols = labyrinth.GetLength(1);

        public static void Main()
        {
            FindTheLargestConnectedArea(rows, cols);
        }

        public static void FindTheLargestConnectedArea(int rows, int cols)
        {
            int number = 0, step = 0, count = 0, maxCount = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (labyrinth[row, col] == " ")
                    {
                        FindArea(row, col, step, ref count);
                        if (count >= maxCount)
                        {
                            maxCount = count;
                            number = step;
                        }

                        count = 0;
                        step++;
                    }
                }
            }

            PrintLabyrint(number.ToString());
            Console.WriteLine("The largest area is from {0} with count {1}", number, maxCount);
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

        public static void PrintLabyrint(string number)
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