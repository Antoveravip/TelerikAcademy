namespace SimpleMathOperation
{
    using System;

    // I do changes for "i" in the body of the loop - better view.
    internal static class Decrement
    {
        internal static void DecrementInt(int startValue, int endValue)
        {
            for (int i = startValue; i > endValue; )
            {
                i--;
            }
        }

        internal static void DecrementLong(long startValue, long endValue)
        {
            for (long i = startValue; i > endValue; )
            {
                i--;
            }
        }

        internal static void DecrementFloat(float startValue, float endValue)
        {
            for (float i = startValue; i > endValue; )
            {
                i--;
            }
        }

        internal static void DecrementDouble(double startValue, double endValue)
        {
            for (double i = startValue; i > endValue; )
            {
                i--;
            }
        }

        internal static void DecrementDecimal(decimal startValue, decimal endValue)
        {
            for (decimal i = startValue; i > endValue; )
            {
                i--;
            }
        }
    }
}