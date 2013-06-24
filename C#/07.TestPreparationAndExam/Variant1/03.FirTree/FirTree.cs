using System;

class FirTree
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        string dot, asterisk;
        for (int row = 0; row <= n - 1; row++)
        {
            if (row != (n - 1))
            {
                dot = new string('.', ((n - 2) - row));
                asterisk = new string('*', (2 * row) + 1);
                Console.WriteLine("{0}{1}{2}", dot, asterisk, dot);
            }
            else if (row == n - 1)
            {
                dot = new string('.', (n - 2));
                asterisk = new string('*', (n - row));
                Console.WriteLine("{0}{1}{2}", dot, asterisk, dot);
            }
        }
    }
}