using System;

class FallDown
{
    static void Main()
    {
        //Input data
        byte n0 = byte.Parse(Console.ReadLine());
        byte n1 = byte.Parse(Console.ReadLine());
        byte n2 = byte.Parse(Console.ReadLine());
        byte n3 = byte.Parse(Console.ReadLine());
        byte n4 = byte.Parse(Console.ReadLine());
        byte n5 = byte.Parse(Console.ReadLine());
        byte n6 = byte.Parse(Console.ReadLine());
        byte n7 = byte.Parse(Console.ReadLine());

        //Calculations
        //n1 = n1 | n0;
        //n0 = n1 & n0;
        for (byte num = 0; num < 8; num++)
        {
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n7 >> bit) & 1) == 0 && ((n6 >> bit) & 1) == 1)
                {
                    n7 = (byte)(n7 | (1 << bit));
                    n6 = (byte)(n6 & (~(1 << bit)));
                }
            }
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n6 >> bit) & 1) == 0 && ((n5 >> bit) & 1) == 1)
                {
                    n6 = (byte)(n6 | (1 << bit));
                    n5 = (byte)(n5 & (~(1 << bit)));
                }
            }
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n5 >> bit) & 1) == 0 && ((n4 >> bit) & 1) == 1)
                {
                    n5 = (byte)(n5 | (1 << bit));
                    n4 = (byte)(n4 & (~(1 << bit)));
                }
            }
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n4 >> bit) & 1) == 0 && ((n3 >> bit) & 1) == 1)
                {
                    n4 = (byte)(n4 | (1 << bit));
                    n3 = (byte)(n3 & (~(1 << bit)));
                }
            }
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n3 >> bit) & 1) == 0 && ((n2 >> bit) & 1) == 1)
                {
                    n3 = (byte)(n3 | (1 << bit));
                    n2 = (byte)(n2 & (~(1 << bit)));
                }
            }
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n2 >> bit) & 1) == 0 && ((n1 >> bit) & 1) == 1)
                {
                    n2 = (byte)(n2 | (1 << bit));
                    n1 = (byte)(n1 & (~(1 << bit)));
                }
            }
            for (byte bit = 0; bit <= 7; bit++)
            {
                if (((n1 >> bit) & 1) == 0 && ((n0 >> bit) & 1) == 1)
                {
                    n1 = (byte)(n1 | (1 << bit));
                    n0 = (byte)(n0 & (~(1 << bit)));
                }
            }
        }
        //Output data
        Console.WriteLine(n0);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(n7);
    }
}