namespace SimpleMathOperation
{
    using System;

    // I do changes for "i" in the body of the loop - better view. Purposely I don't use short /= way!
    internal static class DivideValue
    {
        internal static void DivideInt(int startValue, int endValue, int divider)
        {
            for (int i = startValue; i > endValue; )
            {
                i = i / divider;
            }
        }

        internal static void DivideLong(long startValue, long endValue, long divider)
        {
            for (long i = startValue; i > endValue; )
            {
                i = i / divider;
            }
        }

        internal static void DivideFloat(float startValue, float endValue, float divider)
        {
            for (float i = startValue; i > endValue; )
            {
                i = i / divider;
            }
        }

        internal static void DivideDouble(double startValue, double endValue, double divider)
        {
            for (double i = startValue; i > endValue; )
            {
                i = i / divider;
            }
        }

        internal static void DivideDecimal(decimal startValue, decimal endValue, decimal divider)
        {
            for (decimal i = startValue; i > endValue; )
            {
                i = i / divider;
            }
        }
    }
}