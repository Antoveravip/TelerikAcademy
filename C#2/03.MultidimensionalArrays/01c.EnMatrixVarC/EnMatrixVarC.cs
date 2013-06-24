/* Lesson 3 - Multidimensional Arrays
 * Homework 1 - C
 * 
 * Write a program that fills and prints a matrix
 * of size (n, n) as shown below:
 * 
 * (example for n = 4)
 * 
 * 7 11 14 16
 * 4  8 12 15
 * 2  5  9 13
 * 1  3  6 10
 */

using System;

class EnMatrixVarC
{
    static void Main()
    {
        //Get value for matrix[n,n] size
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int row = n - 1;
        int col = 0;
        //Sets the elements value of the matrix
        for (int currentCellValue = 1; currentCellValue <= n * n; currentCellValue++)
        {
            matrix[row++, col++] = currentCellValue;

            if (row == n || col == n)
            {
                row--;
                if (col == n)
                {
                    row--;
                    col--;
                }
                while (row - 1 >= 0 && col - 1 >= 0)
                {
                    row--;
                    col--;
                }
            }
        }
        //The visual formatting working well till n<10
        Console.WriteLine(new string('-', n * 5 + 1));//Visual layout
        for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {
                Console.Write("| {0,2} ", matrix[row, col]);
            }
            Console.Write("|\n");//Visual layout
            Console.WriteLine(new string('-', n * 5 + 1));//Visual layout
        }
    }
}