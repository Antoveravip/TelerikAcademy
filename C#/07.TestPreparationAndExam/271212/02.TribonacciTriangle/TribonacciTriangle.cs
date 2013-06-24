using System;

class TribonacciTriangle
{
    static void Main()
    {
        //Input
        long firstMem = long.Parse(Console.ReadLine());
        long secMem = long.Parse(Console.ReadLine());
        long thirdMem = long.Parse(Console.ReadLine());
        int memberN = int.Parse(Console.ReadLine());
        string emptySpace = new string(' ', 1);
        long nextMem;
        //Solution and output
        if (memberN == 1) { Console.WriteLine(firstMem); }
        if (memberN == 2)
        {
            Console.WriteLine(firstMem);
            Console.WriteLine(secMem + emptySpace + thirdMem);
        }
        else if (memberN >= 3)
        {
            Console.WriteLine(firstMem);
            Console.WriteLine(secMem + emptySpace + thirdMem);
            for (int i = 3; i <= memberN; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    nextMem = firstMem + secMem + thirdMem;
                    firstMem = secMem;
                    secMem = thirdMem;
                    thirdMem = nextMem;
                    if (j < i)
                    {
                        Console.Write(nextMem + emptySpace);
                    }
                    else
                    {
                        Console.Write(nextMem);
                    }                    
                }
                Console.Write('\n');
            }
        }
    }
}