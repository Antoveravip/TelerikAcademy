/* Lesson 3 - Multidimensional Arrays
 * Homework 3
 * 
 * We are given a matrix of strings of size N x M. Sequences in the matrix
 * we define as sets of several neighbor elements located on the same line,
 * column or diagonal. Write a program that finds the longest sequence of
 * equal strings in the matrix. 
 */

using System;

class LongestSequenceInMatrix
{
    static string LongestSequence;
    static int maxLength;

    static void Main()
    {
        // Test matrix -  Declare and initialize the matrix
        string[,] textMatrix = 
		{
			{"ha", "fif", "ho", "hi"},
			{"fo", "ha", "hi", "xx"},
			{"xx", "ho", "ha", "xx"},
		};
        int n = textMatrix.GetLength(0);
        int m = textMatrix.GetLength(1);

        /*
        // Read the matrix dimensions
        Console.Write("Number of rows = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int m = int.Parse(Console.ReadLine());

        // Allocate the matrix
        string[,] textMatrix = new string[n, m];

        // Enter the matrix elements
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                string element = Console.ReadLine();
                textMatrix[row, col] = element;
            }
        }
        */
        maxLength = -1;

        //Search by rows
        for (int i = 0; i < n; i++)
        {
            SearchSequence(textMatrix, i, 0, 0, 1);
        }
        //Search by columns
        for (int i = 0; i < m; i++)
        {
            SearchSequence(textMatrix, 0, i, 1, 0);
        }
        //Search by direct diagonals
        for (int i = 0; i < n; i++)
        {
            SearchSequence(textMatrix, i, 0, -1, 1);
        }
        for (int i = 0; i < m; i++)
        {
            SearchSequence(textMatrix, n - 1, i, -1, 1);
        }
        //Search by opposite diagonals
        for (int i = n - 1; i >= 0; i--)
        {
            SearchSequence(textMatrix, i, 0, 1, 1);
        }
        for (int i = 0; i < m; i++)
        {
            SearchSequence(textMatrix, 0, i, 1, 1);
        }
        //Print the result
        Console.Write("The longest Sequence is:");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(" {0},", LongestSequence);
        }
        Console.Write('\b' + " " + '\n');
    }

    public static void SearchSequence(string[,] textMatrix, int firstRow, int firstCol, int diffRow, int diffCol)
    {
        int currentRow = firstRow;
        int currentCol = firstCol;
        int length = 1;
        string element = textMatrix[firstRow, firstCol];
        while (true)
        {
            currentRow += diffRow;
            currentCol += diffCol;
            if (currentRow < 0 || currentRow >= textMatrix.GetLength(0) || currentCol < 0 || currentCol >= textMatrix.GetLength(1)) break;
            if (textMatrix[currentRow, currentCol] != element)
            {
                if (length > maxLength)
                {
                    maxLength = length;
                    LongestSequence = element;
                }
                length = 1;
                element = textMatrix[currentRow, currentCol];
            }
            else length++;
        }
        if (length > maxLength)
        {
            maxLength = length;
            LongestSequence = element;
        }
    }
}