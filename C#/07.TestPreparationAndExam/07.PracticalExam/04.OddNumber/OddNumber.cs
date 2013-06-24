using System;

class OddNumber
{
    static void Main()
    {
        /*uint eN = uint.Parse(Console.ReadLine());
        long[] numbers = new long[eN];
        for (uint i = 0; i < eN; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        for (uint i = 0; i < eN; i++)
        {
            long oddNumAtTime = numbers[i];
            long count = 0;
            if (eN == 1)
            {
                Console.WriteLine(oddNumAtTime);
                break;
            }
            for (uint k = i; k < eN; k++)
            {
                if (oddNumAtTime == numbers[k])
                {
                    count++;
                }
            }
            if (count % 2 != 0)
            {
                Console.WriteLine(oddNumAtTime);
                break;
            }
        }*/

        int n = int.Parse(Console.ReadLine());
        long result = 0;
        for (int i = 1; i <= n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            result ^= number;
        }
        Console.WriteLine(result);
    }
}