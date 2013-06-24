using System;

class Pillars
{
    static void Main()
    {
        //For solving is used as help authors answer! 
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
        short topScore = Int16.MinValue;
        short bestCol = Int16.MinValue;
        for (byte col = 0; col <= 7; col++)
        {
            byte rightSideCounter = 0;
            for (byte rightCol = 0; rightCol <= col - 1; rightCol++)
            {
                rightSideCounter += (byte)((n0 >> rightCol) & 1);
                rightSideCounter += (byte)((n1 >> rightCol) & 1);
                rightSideCounter += (byte)((n2 >> rightCol) & 1);
                rightSideCounter += (byte)((n3 >> rightCol) & 1);
                rightSideCounter += (byte)((n4 >> rightCol) & 1);
                rightSideCounter += (byte)((n5 >> rightCol) & 1);
                rightSideCounter += (byte)((n6 >> rightCol) & 1);
                rightSideCounter += (byte)((n7 >> rightCol) & 1);
            }
            byte leftSideCounter = 0;
            for (byte leftCol = (byte)(col + 1); leftCol <= 7; leftCol++)
            {
                leftSideCounter += (byte)((n0 >> leftCol) & 1);
                leftSideCounter += (byte)((n1 >> leftCol) & 1);
                leftSideCounter += (byte)((n2 >> leftCol) & 1);
                leftSideCounter += (byte)((n3 >> leftCol) & 1);
                leftSideCounter += (byte)((n4 >> leftCol) & 1);
                leftSideCounter += (byte)((n5 >> leftCol) & 1);
                leftSideCounter += (byte)((n6 >> leftCol) & 1);
                leftSideCounter += (byte)((n7 >> leftCol) & 1);
            }
            if (leftSideCounter == rightSideCounter)
            {
                topScore = leftSideCounter;
                bestCol = col;
            }
        }
        if (topScore != Int16.MinValue)
        {
            Console.WriteLine(bestCol);
            Console.WriteLine(topScore);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}