using System;

class FighterAttack
{
    static void Main()
    {
        //Input
        int P1X = int.Parse(Console.ReadLine());
        int P1Y = int.Parse(Console.ReadLine());
        int P2X = int.Parse(Console.ReadLine());
        int P2Y = int.Parse(Console.ReadLine());
        int FX = int.Parse(Console.ReadLine());
        int FY = int.Parse(Console.ReadLine());
        int distanceD = int.Parse(Console.ReadLine());

        //Solution
        ushort totalDamage = 0;
        //Ship borders
        int minPX = Math.Min(P1X, P2X);
        int maxPX = Math.Max(P1X, P2X);
        int minPY = Math.Min(P1Y, P2Y);
        int maxPY = Math.Max(P1Y, P2Y);
        //Hit
        int hit = FX + distanceD;

        //Find the damage
        if ((hit < (minPX - 1)) || (hit > maxPX) || (FY > (maxPY + 1)) || (FY < (minPY - 1)))
        {
            totalDamage = 0; //No damage
        }
        else
        {
            if (((hit >= minPX) && (hit <= (maxPX - 1))) && ((FY >= (minPY + 1)) && (FY <= (maxPY - 1))))
            {
                totalDamage = 275; //Max damge
            }
            else if (hit == maxPX) //Back
            {
                if ((FY >= (minPY + 1)) && (FY <= (maxPY - 1)))
                {
                    totalDamage = 200;
                }
                if (FY == minPY || FY == maxPY)
                {
                    totalDamage = 150;
                }
                if ((FY == (minPY - 1)) || (FY == (maxPY + 1)))
                {
                    totalDamage = 50;
                }
                if(minPX == maxPX && minPY == maxPY) //If target is point
                {
                    totalDamage = 100;
                }
            }
            else if (hit == minPX && (FY == minPY || FY == maxPY)) //Borders
            {
                totalDamage = 225;
            }
            else if (((hit > minPX) && (hit < maxPX)) && (FY == minPY || FY == maxPY))
            {
                totalDamage = 225;
            }
            else if ((hit == (minPX - 1)) && ((FY >= minPY) && (FY <= maxPY))) //Front
            {
                totalDamage = 75;
            }
            else if (((hit >= minPX) && (hit <= maxPX)) && (FY == (minPY - 1) || FY == (maxPY + 1)))
            {
                totalDamage = 50;
            }
        }
        Console.WriteLine("{0}%", totalDamage);
    }
}