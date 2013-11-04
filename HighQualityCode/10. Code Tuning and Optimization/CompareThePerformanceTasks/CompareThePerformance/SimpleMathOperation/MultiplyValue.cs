namespace SimpleMathOperation
{
    using System;

    // I do changes for "i" in the body of the loop - better view. Purposely I don't use short *= way!
    internal static class MultiplyValue
    {
        internal static void MultiplyInt(int startValue, int endValue, int multiplier)
        {
            for (int i = startValue; i < endValue; )
            {
                i = i * multiplier;
            }
        }

        internal static void MultiplyLong(long startValue, long endValue, long multiplier)
        {
            for (long i = startValue; i < endValue; )
            {
                i = i * multiplier;
            }
        }

        internal static void MultiplyFloat(float startValue, float endValue, float multiplier)
        {
            for (float i = startValue; i < endValue; )
            {
                i = i * multiplier;
            }
        }

        internal static void MultiplyDouble(double startValue, double endValue, double multiplier)
        {
            for (double i = startValue; i < endValue; )
            {
                i = i * multiplier;
            }
        }

        internal static void MultiplyDecimal(decimal startValue, decimal endValue, decimal multiplier)
        {
            for (decimal i = startValue; i < endValue; )
            {
                i = i * multiplier;
            }
        }
    }
}