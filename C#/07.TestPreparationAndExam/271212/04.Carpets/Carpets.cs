using System;

class Carpets
{
    static void Main()
    {
        //Input
        byte N = byte.Parse(Console.ReadLine());
        byte count = 0, counter = N;
        //Upper half
        for (int row = N / 2; row > 0; row--)
        {
            for (int col = 1; col <= N;)
            {
                if (col == row)
                {
                    Console.Write("/");
                    col++;
                }
                if (col == ((N - row) + 1))
                {
                    Console.Write("\\");
                    col++;
                }



                /*if (count >= 2 && row == N / 2 - count)
                {
                    if (col == row + count)
                    {
                        Console.Write("/");
                        col++;
                    }
                    if (col == ((N - (row + count)) + 1))
                    {
                        Console.Write("\\");
                        col++;
                    }
                    if (col == N / 2 && row + count != N / 2) //(((N / 2) % 2) != 0))
                    {
                        Console.Write(" ");
                        col++;
                    }
                }*/
                else if (col > row && (col < ((N - row) + 1)))
                {
                    for (int k = 2; k <= N / 6; k = k + 2)
                    {
                        if (col <= N / 2 && col == row + 2)
                        {
                            Console.Write("/");
                            col++;
                        }
                        if (col > N / 2 && col == ((N - row) + 1) - 2)
                        {
                            Console.Write("\\");
                            col++;
                        }

                        else
                        {
                            Console.Write(" ");
                            col++;
                        }

                    }
                }
                else
                {
                    Console.Write(".");
                    col++;
                }
            }
            Console.WriteLine();
            count++;
        }
        //Second half
        for (int row = 1; row <= N / 2; row++)
        {
            for (int col = 1; col <= N; )
            {
                if (col == row)
                {
                    Console.Write("\\");
                    col++;
                }
                if (col == ((N - row) + 1))
                {
                    Console.Write("/");
                    col++;
                }
                /*if (col == N / 2 && row != N / 2) //(((N / 2) % 2) != 0))
                {
                    Console.Write(" ");
                    col++;
                }
                /*if (count >= 2 && row == N / 2 - count)
                {
                    if (col == row + count)
                    {
                        Console.Write("/");
                        col++;
                    }
                    if (col == ((N - (row + count)) + 1))
                    {
                        Console.Write("\\");
                        col++;
                    }
                    if (col == N / 2 && row + count != N / 2) //(((N / 2) % 2) != 0))
                    {
                        Console.Write(" ");
                        col++;
                    }
                }*/
                else if (col > row && (col < ((N - row) + 1)))
                {
                    Console.Write(" ");
                    col++;
                }
                else
                {
                    Console.Write(".");
                    col++;
                }
            }
            Console.WriteLine();
            count++;
        }
    }
}