namespace SimpleMathOperation
{
    using System;

    // I do changes for "i" in the body of the loop - better view. Purposely I don't use short -= way!
    internal static class SubtractValue
    {
        internal static void SubtractInt(int startValue, int endValue, int decrement)
        {
            for (int i = startValue; i > endValue; )
            {
                i = i - decrement;
            }
        }

        internal static void SubtractLong(long startValue, long endValue, long decrement)
        {
            for (long i = startValue; i > endValue; )
            {
                i = i - decrement;
            }
        }

        internal static void SubtractFloat(float startValue, float endValue, float decrement)
        {
            for (float i = startValue; i > endValue; )
            {
                i = i - decrement;
            }
        }

        internal static void SubtractDouble(double startValue, double endValue, double decrement)
        {
            for (double i = startValue; i > endValue; )
            {
                i = i - decrement;
            }
        }

        internal static void SubtractDecimal(decimal startValue, decimal endValue, decimal decrement)
        {
            for (decimal i = startValue; i > endValue; )
            {
                i = i - decrement;
            }
        }
    }
}