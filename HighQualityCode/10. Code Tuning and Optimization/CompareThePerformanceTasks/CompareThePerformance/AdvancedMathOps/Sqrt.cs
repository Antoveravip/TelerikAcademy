namespace AdvancedMathOps
{
    using System;

    internal static class Sqrt
    {
        internal static void SqrtFloat(float startValue, float endValue, float increment)
        {
            for (float i = startValue; i <= endValue; i += increment)
            {
                Math.Sqrt(i);
            }
        }

        internal static void SqrtDouble(double startValue, double endValue, double increment)
        {
            for (double i = startValue; i <= endValue; i += increment)
            {
                Math.Sqrt(i);
            }
        }

        internal static void SqrtDecimal(decimal startValue, decimal endValue, decimal increment)
        {
            for (decimal i = startValue; i <= endValue; i += increment)
            {
                Math.Sqrt((double)i);
            }
        }
    }
}