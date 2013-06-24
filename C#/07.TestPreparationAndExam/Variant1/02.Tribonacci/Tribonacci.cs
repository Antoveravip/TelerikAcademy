using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        //Input
        BigInteger firstMem = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger secMem = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger thirdMem = new BigInteger(int.Parse(Console.ReadLine()));
        int memberN = int.Parse(Console.ReadLine());
        BigInteger nextTribMem = 0;
        //Solution
        if (memberN == 1) Console.WriteLine(firstMem);
        if (memberN == 2) Console.WriteLine(secMem);
        if (memberN == 3) Console.WriteLine(thirdMem);
        else
        {
            for (int i = 4; i <= memberN; i++)
            {
                nextTribMem = firstMem + secMem + thirdMem;
                firstMem = secMem;
                secMem = thirdMem;
                thirdMem = nextTribMem;
            }
            Console.WriteLine(nextTribMem);
        }
    }
}