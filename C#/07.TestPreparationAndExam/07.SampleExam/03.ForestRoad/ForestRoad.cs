using System;

class ForestRoad
{
    static void Main()
    {
        //Input
        byte n = byte.Parse(Console.ReadLine());

        //Output
        for (byte row = 1; row <= n; row++)
        {
            for (byte col = 1; col <= n; col++)
            {
                if (col == row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (byte row = (byte)(n - (byte)(1)); row >= 1; row--)
        {
            for (byte col = 1; col <= n; col++)
            {
                if (col == row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}