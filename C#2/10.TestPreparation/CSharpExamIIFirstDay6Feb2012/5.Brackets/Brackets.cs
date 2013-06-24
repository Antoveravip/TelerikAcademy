using System;
using System.Numerics;

class Brackets
{
    static string bracketsPattern ;
    static bool[,] showPl;
    static short patternLength;
    static BigInteger[,] braVar;    

    static void Main()
    {
        bracketsPattern = Console.ReadLine();
        patternLength = (short)bracketsPattern.Length;

        braVar = new BigInteger[patternLength, patternLength];
        showPl = new bool[patternLength, patternLength];

        Console.WriteLine(CheckSequences(0, 0));
    }

    static BigInteger CheckSequences(int pos, int openBrack)
    {
        if (pos == patternLength)
        {
            if (openBrack == 0)
            {
                return new BigInteger(1);
            }
            else
            {
                return new BigInteger(0);
            }
        }
        if (openBrack < 0)
        {
            return new BigInteger(0);
        }
        if (showPl[pos, openBrack])
        {
            return braVar[pos, openBrack];
        }
        else
        {
            showPl[pos, openBrack] = true;
            BigInteger variants = new BigInteger(0);

            if (bracketsPattern[pos] == ')')
            {
                variants = CheckSequences(pos + 1, openBrack - 1);
            }
            else if (bracketsPattern[pos] == '(')
            {
                variants = CheckSequences(pos + 1, openBrack + 1);
            }
            else
            {
                variants = CheckSequences(pos + 1, openBrack + 1);
                variants = variants + CheckSequences(pos + 1, openBrack - 1);
            }

            braVar[pos, openBrack] = variants;
            return variants;
        }
    }
}