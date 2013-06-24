using System;

class Sheets
{
    static void Main()
    {
        //Input
        short N = short.Parse(Console.ReadLine());

        //Calculations and output
        short allSheets = 2047;
        short needSheets = (short)(allSheets - N);
        for (int i = 0; i <= 10; i++)
        {
            short bitPosition = (short)(i);
            short mask = (short)(1 << bitPosition);
            short needSheetsAndMask = (short)(needSheets & mask);
            if ((needSheetsAndMask >> (i)) == 1)
            {
                Console.WriteLine("A{0}", (10 - i));
            }
        }
    }
}