using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());
        decimal mathExpression = ((N * N + (1m / (M * P)) + 1337m) /
                                    (N - (128.523123123m * P)))
                                    + (decimal)(Math.Sin((int)M % 180));
        Console.WriteLine(Math.Round(mathExpression, 6));
    }
}