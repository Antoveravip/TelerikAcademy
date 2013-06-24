using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        short n = short.Parse(Console.ReadLine());
        for (short i = 1; i <= n; i++)
        {
            int count = 0;
            uint num = uint.Parse(Console.ReadLine());
            while (num != 0)
            {
                if ((num & 1) == b)
                {
                    count++;
                }
                num = num >> 1;
            }
            Console.WriteLine(count);
        }
    }
}