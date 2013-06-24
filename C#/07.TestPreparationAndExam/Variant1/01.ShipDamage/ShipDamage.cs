using System;

class ShipDamage
{
    static void Main()
    {
        //Input
        int S1X = int.Parse(Console.ReadLine());
        int S1Y = int.Parse(Console.ReadLine());
        int S2X = int.Parse(Console.ReadLine());
        int S2Y = int.Parse(Console.ReadLine());
        int horisonH = int.Parse(Console.ReadLine());
        int C1X = int.Parse(Console.ReadLine());
        int C1Y = int.Parse(Console.ReadLine());
        int C2X = int.Parse(Console.ReadLine());
        int C2Y = int.Parse(Console.ReadLine());
        int C3X = int.Parse(Console.ReadLine());
        int C3Y = int.Parse(Console.ReadLine());

        //Solution
        ushort shipDamage = 0;
        //Ship borders
        int minSX = Math.Min(S1X, S2X);
        int maxSX = Math.Max(S1X, S2X);
        int minSY = Math.Min(S1Y, S2Y);
        int maxSY = Math.Max(S1Y, S2Y);
        //Hit C
        int hitC1 = 2 * horisonH - C1Y;
        int hitC2 = 2 * horisonH - C2Y;
        int hitC3 = 2 * horisonH - C3Y;
        //Find the damage
        if (((C1X > maxSX) || (C1X < minSX) || (((C1X >= minSX) && (C1X <= maxSX)) && ((hitC1 < minSY) || (hitC1 > maxSY)))))
        {
            shipDamage += 0; // No hit
        }
        else
        {
            if (((hitC1 > minSY) && (hitC1 < maxSY)) && ((C1X > minSX) && (C1X < maxSX)))
            {
                shipDamage += 100; //Total inline hit
            }
            else if ((hitC1 == minSY || hitC1 == maxSY) && ((C1X > minSX) && (C1X < maxSX))
                     || ((hitC1 > minSY) && (hitC1 < maxSY)) && (C1X == minSX || C1X == maxSX))
            {
                shipDamage += 50; // Border hit
            }
            else
            {
                shipDamage += 25; // Corner hit
            }
        }
        if (((C2X > maxSX) || (C2X < minSX) || (((C2X >= minSX) && (C2X <= maxSX)) && ((hitC2 < minSY) || (hitC2 > maxSY)))))
        {
            shipDamage += 0; // No hit
        }
        else
        {
            if (((hitC2 > minSY) && (hitC2 < maxSY)) && ((C2X > minSX) && (C2X < maxSX)))
            {
                shipDamage += 100; //Total inline hit
            }
            else if ((hitC2 == minSY || hitC2 == maxSY) && ((C2X > minSX) && (C2X < maxSX))
                     || ((hitC2 > minSY) && (hitC2 < maxSY)) && (C2X == minSX || C2X == maxSX))
            {
                shipDamage += 50; // Border hit
            }
            else
            {
                shipDamage += 25; // Corner hit
            }
        }
        if (((C3X > maxSX) || (C3X < minSX) || (((C3X >= minSX) && (C3X <= maxSX)) && ((hitC3 < minSY) || (hitC3 > maxSY)))))
        {
            shipDamage += 0; // No hit
        }
        else
        {
            if (((hitC3 > minSY) && (hitC3 < maxSY)) && ((C3X > minSX) && (C3X < maxSX)))
            {
                shipDamage += 100; //Total inline hit
            }
            else if ((hitC3 == minSY || hitC3 == maxSY) && ((C3X > minSX) && (C3X < maxSX))
                     || ((hitC3 > minSY) && (hitC3 < maxSY)) && (C3X == minSX || C3X == maxSX))
            {
                shipDamage += 50; // Border hit
            }
            else
            {
                shipDamage += 25; // Corner hit
            }
        }
        Console.WriteLine("{0}%", shipDamage);
    }
}