using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartII
{
    public class Matrix<T>
    where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        // --- FIELDS --- //
        private int rows;
        private int cols;
        private T[,] cellValue;

        // --- PROPERTIES --- //
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }

        // --- INDEXERS --- //
        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    return cellValue[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format("Cell ({0}, {1}) is not correct.", row, col));
                }
            }
            set
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    cellValue[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format("Cell ({0}, {1}) is not correct.", row, col));
                }
            }
        }

        // --- CONSTRUCTORS --- //

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new IndexOutOfRangeException("Matrix dimensions must be positive integers.");
            }

            this.rows = rows;
            this.cols = cols;
            this.cellValue = new T[rows, cols];
        }

        public Matrix(T[,] value)
        {
            if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
            {
                throw new ArgumentOutOfRangeException("The two-dimensional initialization array must contain at least one item.");
            }
            this.rows = value.GetLength(0);
            this.cols = value.GetLength(1);
            value = (T[,])value.Clone();
        }

        // --- MATRIX OPERATORS --- //
        public static Matrix<T> operator -(Matrix<T> matrix)
        {
            return Multiply(-1, matrix);
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            return Add(firstMatrix, secondMatrix);
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            return Add(firstMatrix, -secondMatrix);
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            return Multiply(firstMatrix, secondMatrix);
        }

        public static Matrix<T> operator *(int constant, Matrix<T> matrix)
        {
            return Multiply(constant, matrix);
        }

        public static Matrix<T> operator *(Matrix<T> matrix, int constant)
        {
            return Multiply(constant, matrix);
        }

        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.cols == 0)
            {
                return false;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.cols == 0)
            {
                return true;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // --- METHODS --- //
        // Transposition of a matrix
        public Matrix<T> Transposition()
        {
            Matrix<T> transposedMatrix = new Matrix<T>(cols, rows);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    transposedMatrix[col, row] = cellValue[row, col];
                }
            }
            return transposedMatrix;
        }

        //Copying of the matrix
        public Matrix<T> Clone()
        {
            Matrix<T> cloneMatrix = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    cloneMatrix[row, col] = cellValue[row, col];
                }
            }
            return cloneMatrix;
        }

        private string CellsValueToString()
        {
            int row;
            int col;
            int maxLength = -1, length;
            for (row = 0; row < rows; row++)
            {
                for (col = 0; col < cols; col++)
                {
                    length = cellValue[row, col].ToString().Length;
                    if (maxLength < length)
                    {
                        maxLength = length;
                    }
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\r\n");

            for (row = 0; row < rows; row++)
            {
                stringBuilder.Append("\t|");

                for (col = 0; col < cols; col++)
                {
                    stringBuilder.Append(cellValue[row, col].ToString().PadLeft(maxLength + 1, ' '));
                }

                stringBuilder.AppendFormat("{0,2}\r\n", '|');
            }
            return stringBuilder.ToString();
        }

        public T[,] GetCellsValue()
        {
            T[,] cellsValues = new T[rows, cols];
            Array.Copy(this.cellValue, 0, cellsValues, 0, this.cellValue.Length);
            return cellsValues;
        }

        public override string ToString()
        {
            return CellsValueToString();
        }

        //Sum of matrices
        private static Matrix<T> Add(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Missing initialization of one or more matrices.");
            }

            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                        }
                    }
                }

                return result;
            }
            catch (OverflowException ex)
            {
                throw new OverflowException("Addition resulted in an overflow.", ex);
            }
        }

        //Multiplying of matrix and constant
        private static Matrix<T> Multiply(int constant, Matrix<T> matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("Matrix is not initialized.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(matrix.rows, matrix.cols);

                for (int row = 0; row < matrix.rows; row++)
                {
                    for (int col = 0; col < matrix.cols; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)matrix[row, col] * constant;
                        }
                    }
                }
                return result;
            }
            catch (OverflowException ex)
            {
                throw new OverflowException("Multiplication resulted in an overflow for current type.", ex);
            }
        }

        //Multiplying of matrices
        private static Matrix<T> Multiply(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Missing initialization of one or more matrices.");
            }

            if (firstMatrix.cols != secondMatrix.rows)
            {
                throw new ArgumentException("Not correct dimensions of matrices!");
            }

            try
            {
                Matrix<T> aftermath = new Matrix<T>(firstMatrix.rows, secondMatrix.cols);

                for (int row = 0; row < aftermath.rows; row++)
                {
                    for (int col = 0; col < aftermath.cols; col++)
                    {
                        aftermath[row, col] = default(T);
                        for (int i = 0; i < firstMatrix.cols; i++)
                        {
                            checked
                            {
                                aftermath[row, col] += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                            }
                        }
                    }
                }
                return aftermath;
            }
            catch (OverflowException ex)
            {
                throw new OverflowException("Multiplication resulted in an overflow for current type.", ex);
            }
        }  
    }
}