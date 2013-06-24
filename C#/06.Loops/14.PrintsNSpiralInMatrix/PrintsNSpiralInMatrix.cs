/* Lesson 6 - Loops
 * Homework 14 *
 * Write a program that reads a positive integer number
 * N (N < 20) from console and outputs in the console
 * the numbers 1 ... N numbers arranged as a spiral.
 * 
 * Example for N = 4
 * 
 *  1  2  3 4
 * 12 13 14 5
 * 11 16 15 6
 * 10  9  8 7
 */ 

using System;

class PrintsNSpiralInMatrix
{
    static int n, number, row, col;
    static string inputData;
    static bool check = false;
    // Check input data
    static void InputCheck()
    {
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out number);
            if (check == false || number >= 20 || number <= 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = int.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter value for N=");
        InputCheck();
        n = number;
        //Declaring and allocating two-dimensional array with entered number
        int[,] nMatrix = new int[n, n];
        //Assign values zero ​​to all elements of array /no need - just in case!/
        for (byte i = 0; i < n; i++)
        {
            for (byte k = 0; k < n; k++)
            {
                nMatrix[i, k] = 0;
            }
        }
        int rowShift = 0, colShift = 1, count = 0;
        //Assign needed values ​​to all elements of array - values to be arranged as a spiral
        while (nMatrix[row, col] == 0) //Checks while there are elements whose value is 0
        {
            nMatrix[row, col] = ++count;
            //Checks the borders of the array
            if (row + rowShift > n - 1 ||
                row + rowShift < 0 ||
                col + colShift > n - 1 ||
                col + colShift < 0 ||
                nMatrix[row + rowShift, col + colShift] > 0)
            {
                if (rowShift == 0)
                {
                    rowShift = colShift;
                    colShift = 0;
                }
                else
                {
                    colShift = -rowShift;
                    rowShift = 0;
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
                Console.Write("| {0,3} ", nMatrix[j, m]);
            }
            Console.Write("|\n"); //Visual layout
            Console.WriteLine(new string('-', n * 6 + 1)); //Visual layout
        }
    }
}