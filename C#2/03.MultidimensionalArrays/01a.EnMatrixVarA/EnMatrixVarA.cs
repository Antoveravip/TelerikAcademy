/* Lesson 3 - Multidimensional Arrays
 * Homework 1 - A
 * 
 * Write a program that fills and prints a matrix
 * of size (n, n) as shown below:
 * 
 * (example for n = 4)
 * 
 * 1 5  9 13
 * 2 6 10 14
 * 3 7 11 15
 * 4 8 12 16
 */

using System;

class EnMatrixVarA
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
                matrix[row, col] = n * col + row + 1;
                Console.Write("| {0,2} ", matrix[row, col]);
            }
            Console.Write("|\n");//Visual layout
            Console.WriteLine(new string('-', n * 5 + 1));//Visual layout
        }
    }
}