namespace AdvancedMathOps
{
    using System;

    internal static class Sinus
    {
        internal static void SinusFloat(float startValue, float endValue, float increment)
        {
            for (float i = startValue; i <= endValue; i += increment)
            {
                Math.Sin(i);
            }
        }

        internal static void SinusDouble(double startValue, double endValue, double increment)
        {
            for (double i = startValue; i <= endValue; i += increment)
            {
                Math.Sin(i);
            }
        }

        internal static void SinusDecimal(decimal startValue, decimal endValue, decimal increment)
        {
            for (decimal i = startValue; i <= endValue; i += increment)
            {
                Math.Sin((double)i);
            }
        }    
    }
}