namespace AdvancedMathOps
{
    using System;

    internal static class LogE
    {
        internal static void LogEFloat(float startValue, float endValue, float increment)
        {
            for (float i = startValue; i <= endValue; i += increment)
            {
                Math.Log(i, Math.E);
            }
        }

        internal static void LogEDouble(double startValue, double endValue, double increment)
        {
            for (double i = startValue; i <= endValue; i += increment)
            {
                Math.Log(i, Math.E);
            }
        }

        internal static void LogEDecimal(decimal startValue, decimal endValue, decimal increment)
        {
            for (decimal i = startValue; i <= endValue; i += increment)
            {
                Math.Log((double)i, Math.E);
            }
        }
    }
}