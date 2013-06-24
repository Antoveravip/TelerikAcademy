using System;

class SandGlass
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        for (int row = 0; row <= n/2; row++)
        {
            string dot = new string('.', row);
            string asterisk = new string('*', (n - 2 * row));
            Console.WriteLine("{0}{1}{2}", dot, asterisk, dot);
        }
        for (int row = n / 2 - 1; row >= 0; row--)
        {
            string dot = new string('.', row);
            string asterisk = new string('*', (n - 2 * row));
            Console.WriteLine("{0}{1}{2}", dot, asterisk, dot);
        }
    }
}