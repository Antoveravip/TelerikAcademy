namespace Matrix
{
    using System;
    using System.Text;

    public class MatrixEngine
    {
        private const int PossibleDirections = 8;
        private const int MinMatrixDimension = 1;
        private const int MaxMatrixDimension = 100;

        private int matrixDimension;
        private int[,] matrix;
        private int row = 0;
        private int col = 0;

        public MatrixEngine(int dimentions)
        {
            this.Dimentions = dimentions;

            this.matrix = new int[this.matrixDimension, this.matrixDimension];

            this.FindAvailableCell();
            this.FillAvailableCells();
        }

        public int Dimentions
        {
            get
            {
                return this.matrixDimension;
            }

            set
            {
                if (MinMatrixDimension > value || value > MaxMatrixDimension)
                {
                    throw new ArgumentOutOfRangeException("matrixDimension", "Matrix dimention must be between 1 and 100!");
                }

                this.matrixDimension = value;
            }
        }

        public override string ToString()
        {
            StringBuilder matrixAsStirng = new StringBuilder();

            for (int row = 0; row < this.matrixDimension; row++)
            {
                for (int col = 0; col < this.matrixDimension; col++)
                {
                    matrixAsStirng.AppendFormat("{0,3}", this.matrix[row, col]);
                }

                matrixAsStirng.Append("\r\n");
            }

            return matrixAsStirng.ToString();
        }

        private void ChangeDirection(ref int wayByRow, ref int wayByCol)
        {
            int[] directionByRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionByCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDirection = 0;

            for (int direction = 0; direction < PossibleDirections; direction++)
            {
                if (directionByRow[direction] == wayByRow && directionByCol[direction] == wayByCol)
                {
                    currentDirection = direction;
                    break;
                }
            }

            if (currentDirection == PossibleDirections - 1)
            {
                wayByRow = directionByRow[0];
                wayByCol = directionByCol[0];
                return;
            }

            wayByRow = directionByRow[currentDirection + 1];
            wayByCol = directionByCol[currentDirection + 1];
        }

        private bool IsInRange(int value)
        {
            if (value >= this.matrixDimension || value < 0)
            {
                return false;
            }

            return true;
        }

        private bool IsNextCellAvailable(int row, int col, int[] directionRow, int[] directionCol)
        {
            for (int dirIndex = 0; dirIndex < PossibleDirections; dirIndex++)
            {
                int nextRow = row + directionRow[dirIndex];
                int nextCol = col + directionCol[dirIndex];

                if (this.matrix[nextRow, nextCol] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsCellAvailable(int row, int col)
        {
            int[] directionByRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionByCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int direction = 0; direction < PossibleDirections; direction++)
            {
                int nextRow = row + directionByRow[direction];

                if (!this.IsInRange(nextRow))
                {
                    directionByRow[direction] = 0;
                }

                int nextCol = col + directionByCol[direction];

                if (!this.IsInRange(nextCol))
                {
                    directionByCol[direction] = 0;
                }
            }

            bool isNextCellAvailable = this.IsNextCellAvailable(row, col, directionByRow, directionByCol);

            return isNextCellAvailable;
        }

        private void FindAvailableCell()
        {
            this.row = 0;
            this.col = 0;

            for (int currentRow = 0; currentRow < this.matrixDimension; currentRow++)
            {
                for (int currentCol = 0; currentCol < this.matrixDimension; currentCol++)
                {
                    if (this.matrix[currentRow, currentCol] == 0)
                    {
                        this.row = currentRow;
                        this.col = currentCol;
                        return;
                    }
                }
            }
        }

        private void FillAvailableCells()
        {
            int directionRow = 1;
            int directionCol = 1;
            int number = 1;

            while (true)
            {
                this.matrix[this.row, this.col] = number;

                if (!this.IsCellAvailable(this.row, this.col))
                {
                    this.FindAvailableCell();
                    if (this.IsCellAvailable(this.row, this.col))
                    {
                        number++;
                        this.matrix[this.row, this.col] = number;
                        directionRow = 1;
                        directionCol = 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int nextRow = this.row + directionRow;
                int nextCol = this.col + directionCol;

                if (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                {
                    while (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                    {
                        this.ChangeDirection(ref directionRow, ref directionCol);

                        nextRow = this.row + directionRow;
                        nextCol = this.col + directionCol;
                    }
                }

                this.row = nextRow;
                this.col = nextCol;
                number++;
            }
        }
    }
}