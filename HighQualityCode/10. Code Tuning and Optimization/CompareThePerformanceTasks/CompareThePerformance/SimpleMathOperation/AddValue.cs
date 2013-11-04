namespace SimpleMathOperation
{
    using System;

    // I do changes for "i" in the body of the loop - better view. Purposely I don't use short += way!
    internal static class AddValue
    {
        internal static void AddInt(int startValue, int endValue, int increment)
        {
            for (int i = startValue; i < endValue; )
            {
                i = i + increment;
            }
        }

        internal static void AddLong(long startValue, long endValue, long increment)
        {
            for (long i = startValue; i < endValue; )
            {
                i = i + increment;
            }
        }

        internal static void AddFloat(float startValue, float endValue, float increment)
        {
            for (float i = startValue; i < endValue; )
            {
                i = i + increment;
            }
        }

        internal static void AddDouble(double startValue, double endValue, double increment)
        {
            for (double i = startValue; i < endValue; )
            {
                i = i + increment;
            }
        }

        internal static void AddDecimal(decimal startValue, decimal endValue, decimal increment)
        {
            for (decimal i = startValue; i < endValue; )
            {
                i = i + increment;
            }
        }
    }
}