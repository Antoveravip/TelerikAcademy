/* Lesson 3 - Multidimensional Arrays
 * Homework 1 - D*
 * 
 * Write a program that fills and prints a matrix
 * of size (n, n) as shown below:
 * 
 * (example for n = 4)
 * 
 * 1 12 11 10
 * 2 13 16  9
 * 3 14 15  8
 * 4  5  6  7
 */

using System;

class EnMatrixVarD
{
    static void Main()
    {
        //Get value for matrix[n,n] size
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int rowShift = 1, colShift = 0, count = 0;
        int row = 0, col = 0;
        //Assign needed values ​​to all elements of array - values to be arranged as a spiral
        while (matrix[row, col] == 0) //Checks while there are elements whose value is 0 (By default all elements in new array are 0)
        {
            matrix[row, col] = ++count;
            //Checks the borders of the array
            if (col + colShift > n - 1 ||
                col + colShift < 0 ||
                row + rowShift > n - 1 ||
                row + rowShift < 0 ||
                matrix[row + rowShift, col + colShift] > 0)
            {
                if (colShift == 0)
                {
                    colShift = rowShift;
                    rowShift = 0;
                }
                else
                {
                    rowShift = -colShift;
                    colShift = 0;
                }
            }
            row += rowShift;
            col += colShift;
        }
        //Printing array of console
        //!!! The visual formatting working well till n=13
        Console.WriteLine(new string('-', n * 6 + 1)); //Visual layout
        for (byte j = 0; j < n; j++)
        {
            for (int m = 0; m < n; m++)
            {
                Console.Write("| {0,3} ", matrix[j, m]);
            }
            Console.Write("|\n"); //Visual layout
            Console.WriteLine(new string('-', n * 6 + 1)); //Visual layout
        }
    }
}