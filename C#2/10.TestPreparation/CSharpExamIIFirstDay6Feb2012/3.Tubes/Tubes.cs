using System;

class Tubes
{
    static void Main()
    {
        ushort N = ushort.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int[] tubes = new int[N];
        long sumLength = 0;

        for (int i = 0; i < N; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());
            sumLength += tubes[i];
        }
        if (sumLength < M)
        {
            Console.WriteLine(-1);
            return;
        }
        long left = 1;
        long right = 2000000000;

        while (left + 1 < right)
        {
            long middle = (left + right) / 2;
            long many = 0;
            for (int i = 0; i < N; i++)
            {
                many += tubes[i] / middle;
            }
            if (many >= M)
            {
                left = middle;
            }
            else
            {
                right = middle;
            }
        }
        Console.WriteLine(left);
    }
}