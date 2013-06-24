using System;

class Trapezoid
{
    static void Main()
    {
        //Input
        int N = int.Parse(Console.ReadLine());

        //Output
        for (int i = (N + 1); i >= 1; i--)
        {
            for (int k = 1; k <= 2 * N; k++)
            {
                if (i == 1 || k == (2 * N) || i == k || i == N+1 && k > N)
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