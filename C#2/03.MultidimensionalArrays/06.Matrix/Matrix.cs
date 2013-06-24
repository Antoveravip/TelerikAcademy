/* Lesson 3 - Multidimensional Arrays
 * Homework 6*
 * 
 * Write a class Matrix, to holds a matrix of integers.
 * Overload the operators for adding, subtracting and 
 * multiplying of matrices, indexer for accessing the
 * matrix content and ToString(). 
 */

using System;
using System.Text;

class Matrix
{
    public int[,] matrix;
    public int rows;
    public int cols;

    static void Main()
    {
        Matrix firstMatrix = new Matrix(4, 4);
        firstMatrix.Value[1, 1] = 8;
        Matrix secondMatrix = new Matrix(4, 4);
        secondMatrix.Value[1, 1] = 5;
        Matrix thirdMatrix = new Matrix(4, 4);
        thirdMatrix.Value[1, 1] = 6;

        Console.WriteLine("firstMatrix.Rows: {0}; firstMatrix.Columns: {1}", firstMatrix.Rows, firstMatrix.Cols);
        Console.WriteLine(firstMatrix);
        Console.WriteLine();

        Console.WriteLine("secondMatrix.Rows: {0}; secondMatrix.Columns: {1}", secondMatrix.Rows, secondMatrix.Cols);
        Console.WriteLine(secondMatrix);
        Console.WriteLine();

        Console.WriteLine("thirdMatrix.Rows: {0}; thirdMatrix.Columns: {1}", thirdMatrix.Rows, thirdMatrix.Cols);
        Console.WriteLine(thirdMatrix);
        Console.WriteLine();

        Console.WriteLine("\nfirstMatrix + secondMatrix = \n{0}", firstMatrix + secondMatrix);
        Console.WriteLine("\nfirstMatrix - secondMatrix = \n{0}", firstMatrix - secondMatrix);
        Console.WriteLine("\nfirstMatrix * secondMatrix = \n{0}", firstMatrix * secondMatrix);

        Console.WriteLine("\nfirstMatrix + thirdMatrix = \n{0}", firstMatrix + thirdMatrix);
        Console.WriteLine("\nfirstMatrix * thirdMatrix = \n{0}", firstMatrix * thirdMatrix);

        Console.WriteLine("\nsecondMatrix - thirdMatrix = \n{0}", secondMatrix - thirdMatrix);

        int[,] fMatrix = { { 2, 6, 10, 12, 22, 25 } };
        Matrix fourthMatrix = new Matrix(fMatrix);
        int[,] xMatrix = { { 2 }, { 2 }, { 2 }, { 2 }, { 2 }, { 2 } };
        Matrix exMatrix = new Matrix(xMatrix);

        Console.WriteLine();
        Console.WriteLine("fourthMatrix.Rows: {0}; fourthMatrix: {1}", fourthMatrix.Rows, fourthMatrix.Cols);
        Console.WriteLine(fourthMatrix);
        Console.WriteLine();

        Console.WriteLine("exMatrix.Rows: {0}; exMatrix.Columns: {1}", exMatrix.Rows, exMatrix.Cols);
        Console.WriteLine(exMatrix);
        Console.WriteLine();

        Console.WriteLine("\nfourthMatrix * exMatrix = \n{0}", fourthMatrix * exMatrix);

        Console.WriteLine();
        int r = 0, c = 0;
        Console.WriteLine("(fourthMatrix * exMatrix)[{1},{2}]={0}", (fourthMatrix * exMatrix)[r, c], r, c);
    }

    public int[,] Value
    {
        get
        {
            return this.matrix;
        }
        set
        {
            this.matrix = value;
            this.rows = value.GetLength(0);
            this.cols = value.GetLength(1);
        }
    }

    public int Rows
    {
        get { return this.rows; }
    }

    public int Cols
    {
        get { return this.cols; }
    }

    public Matrix(int[,] matrix)
    {
        this.Value = (int[,])matrix.Clone();
    }

    public Matrix(int rows, int cols) : this(new int[rows, cols]) { }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new FormatException("Matrixes must have same dimensions!");
        }
        else
        {
            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new FormatException("Matrixes must have same dimensions!");
        }
        else
        {
            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Cols != b.Rows)
        {
            throw new FormatException("First matrix columns number must be equal to second matrix rows number!");
        }
        else
        {
            Matrix result = new Matrix(a.Rows, b.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    for (int k = 0; k < a.Cols; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
    }

    public int this[int i, int j]
    {
        get
        {
            return this.Value[i, j];
        }
        set
        {
            this.Value[i, j] = value;
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this[0, 0]);
        for (int j = 1; j < this.Cols; j++)
        {
            result.AppendFormat(" {0}", this[0, j]);
        }
        for (int i = 1; i < this.Rows; i++)
        {
            result.AppendFormat("\n{0}", this[i, 0]);
            for (int j = 1; j < this.Cols; j++)
            {
                result.AppendFormat(" {0}", this[i, j]);
            }
        }
        return result.ToString();
    }
}