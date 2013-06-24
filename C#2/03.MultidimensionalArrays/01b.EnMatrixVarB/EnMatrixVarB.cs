/* Lesson 3 - Multidimensional Arrays
 * Homework 1 - B
 * 
 * Write a program that fills and prints a matrix
 * of size (n, n) as shown below:
 * 
 * (example for n = 4)
 * 
 * 1 8  9 16
 * 2 7 10 15
 * 3 6 11 14
 * 4 5 12 13
 */

using System;

class EnMatrixVarB
{
    static void Main()
    {
        //Get value for matrix[n,n] size
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        //The visual formatting working well till n<10
        Console.WriteLine(new string('-', n * 5 + 1));//Visual layout
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col % 2 != 0)
                {
                    matrix[row, col] = n * col + n - row;
                    Console.Write("| {0,2} ", matrix[row, col]);
                }
                else
                {
                    matrix[row, col] = n * col + row + 1;
                    Console.Write("| {0,2} ", matrix[row, col]);
                }                
            }
            Console.Write("|\n");//Visual layout
            Console.WriteLine(new string('-', n * 5 + 1));//Visual layout
        }
    }
}