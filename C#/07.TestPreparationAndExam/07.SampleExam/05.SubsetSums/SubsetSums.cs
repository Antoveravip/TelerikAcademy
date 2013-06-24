using System;

class SubsetSums
{
    static void Main()
    {
        //Input
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        //Output
        int maxValue = 1;
        for (int i = 1; i <= n; i++)
        {
            maxValue *= 2;
        }
        maxValue -= 1;
        //int maxValue = (int)Math.Pow((double)2, n) - 1;
        int count = 0;
        for (int i = 1; i <= maxValue; i++)
        {
            long currentSum = 0;
            for (int k = 0; k < n; k++)
            {
                int mask = 1 << k;
                int nAndMask = i & mask;
                int bit = nAndMask >> k;
                if (bit == 1)
                {
                    currentSum += numbers[k];
                }                
            }
            if (currentSum == s)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}