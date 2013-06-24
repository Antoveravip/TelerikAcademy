using System;

class MissCat2011
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int[] cat = new int[11];
        for (int i = 1; i <= n; i++)
        {
            byte vote = byte.Parse(Console.ReadLine());
            cat[vote]++;
        }

        //Output
        int bestCat = 0;
        int bestCatVotes = 0;
        for (int k = 1; k <= 10; k++)
        {
            if (cat[k] > bestCatVotes)
            {
                bestCat = k;
                bestCatVotes = cat[k];
            }
        }
        Console.WriteLine(bestCat);
    }
}