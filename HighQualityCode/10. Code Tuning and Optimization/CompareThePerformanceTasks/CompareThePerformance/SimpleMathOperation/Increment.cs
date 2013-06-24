namespace SimpleMathOperation
{
    using System;

    // I do changes for "i" in the body of the loop - better view.
    internal static class Increment
    {
        internal static void IncrementInt(int startValue, int endValue)
        {
            for (int i = startValue; i < endValue; )
            {
                i++;
            }
        }

        internal static void IncrementLong(long startValue, long endValue)
        {
            for (long i = startValue; i < endValue; )
            {
                i++;
            }
        }

        internal static void IncrementFloat(float startValue, float endValue)
        {
            for (float i = startValue; i < endValue; )
            {
                i++;
            }
        }

        internal static void IncrementDouble(double startValue, double endValue)
        {
            for (double i = startValue; i < endValue; )
            {
                i++;
            }
        }

        internal static void IncrementDecimal(decimal startValue, decimal endValue)
        {
            for (decimal i = startValue; i < endValue; )
            {
                i++;
            }
        }
    }
}