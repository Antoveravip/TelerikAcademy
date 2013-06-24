using System;

class WeAllLoveBits
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        for (short i = 1; i <= n; i++)
        {
            int P = int.Parse(Console.ReadLine());
            int Pnew = 0;
            // Pnew = (P ^ P̃) & P̈.
            // P - input number
            // P̃ = ~P
            // (P ^ (~P) = 1111 1111 ..etc.
            // --> Pnew = 1 & P̈ = P̈.
            //Task after all - must invert values ​​of bits in the number P of significant positions
            do
            {
                Pnew = Pnew << 1;
                if ((P & 1) != 0)
                {
                    Pnew = Pnew | 1;
                }
                P = P >> 1;
            }
            while (P > 0);
            Console.WriteLine(Pnew);
        }
    }
}