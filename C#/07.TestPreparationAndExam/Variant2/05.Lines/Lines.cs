using System;

class Lines
{
    static void Main()
    {
        //Input
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int bits = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((bits & (1 << col)) != 0)
                {
                    matrix[row, col] = 1;
                }
            }
        }
        //Calculations
        int maxLength = 0;
        int count = 0;
        //Checks and count in vertical direction
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int length = 0;
                while (col < 8 && matrix[row, col] == 1)
                {
                    col++;
                    length++;
                }
                if (length == maxLength)
                {
                    count++;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    count = 1;
                }
            }
        }
        //Checks and count in horizontal direction
        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                int length = 0;
                while (row < 8 && matrix[row, col] == 1)
                {
                    row++;
                    length++;
                }
                if (length == maxLength)
                {
                    count++;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    count = 1;
                }
            }
        }
        if (maxLength == 1)
        {
            count = count / 2;
        }
        //Output
        Console.WriteLine(maxLength);
        Console.WriteLine(count);
    }
}