namespace AdvancedMathOps
{
    using System;
    using System.Diagnostics;

    public static class PerformancesTests
    {
        internal static TimeSpan DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            return stopwatch.Elapsed;
        }

        internal static TimeSpan FindMinTest(TimeSpan firstCheck, TimeSpan secondCheck, TimeSpan thirdCheck)
        {
            TimeSpan minValue = firstCheck;

            if (secondCheck <= firstCheck)
            {
                minValue = secondCheck;
            }

            if (thirdCheck <= firstCheck)
            {
                minValue = thirdCheck;
            }

            return minValue;
        }

        public static void Main()
        {
            // Primary test all methods
            Sqrt.SqrtFloat(2f, 2000000f, 2f);
            Sqrt.SqrtDouble(2d, 2000000d, 2d);
            Sqrt.SqrtDecimal(2m, 2000000m, 2m);            

            LogE.LogEFloat(2f, 2000000f, 2f);
            LogE.LogEDouble(2d, 2000000d, 2d);
            LogE.LogEDecimal(2m, 2000000m, 2m);            

            Sinus.SinusFloat(2f, 2000000f, 2f);
            Sinus.SinusDouble(2d, 2000000d, 2d);
            Sinus.SinusDecimal(2m, 2000000m, 2m);

            // Secondary test all methods
            Console.WriteLine("Test SqrtFloat VS SqrtDouble VS SqrtDecimal" + Environment.NewLine + new string('-', 60));

            Console.Write("SqrtFloat Time:\t\t\t\t\t");

            TimeSpan firstCheck = DisplayExecutionTime(() =>
            {
                Sqrt.SqrtFloat(2f, 2000000f, 2f);
            });


            Console.Write("SqrtDouble Time:\t\t\t\t");

            TimeSpan secondCheck = DisplayExecutionTime(() =>
            {
                Sqrt.SqrtDouble(2d, 2000000d, 2d);
            });

            Console.Write("SqrtDecimal Time:\t\t\t\t");

            TimeSpan thirdCheck = DisplayExecutionTime(() =>
            {
                Sqrt.SqrtDecimal(2m, 2000000m, 2m); 
            });

            TimeSpan minValue = FindMinTest(firstCheck, secondCheck, thirdCheck);
            Console.WriteLine("SqrtFloat VS SqrtDouble VS SqrtDecimal result:  {0}",  minValue + Environment.NewLine);

            Console.WriteLine("Test LogEFloat VS LogEDouble VS LogEDecimal" + Environment.NewLine + new string('-', 60));

            Console.Write("LogEFloat Time:\t\t\t\t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                LogE.LogEFloat(2f, 2000000f, 2f);
            });


            Console.Write("LogEDouble Time:\t\t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                LogE.LogEDouble(2d, 2000000d, 2d);
            });

            Console.Write("LogEDecimal Time:\t\t\t\t");

            thirdCheck = DisplayExecutionTime(() =>
            {
                LogE.LogEDecimal(2m, 2000000m, 2m);   
            });

            Console.WriteLine("LogEFloat VS LogEDouble VS LogEDecimal result:  {0}", FindMinTest(firstCheck, secondCheck, thirdCheck) + Environment.NewLine);

            Console.WriteLine("Test SinusFloat VS SinusDouble VS SinusDecimal" + Environment.NewLine + new string('-', 60));

            Console.Write("SinusFloat Time:\t\t\t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                Sinus.SinusFloat(2f, 2000000f, 2f);
            });


            Console.Write("SinusDouble Time:\t\t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                Sinus.SinusDouble(2d, 2000000d, 2d);
            });

            Console.Write("SinusDecimal Time:\t\t\t\t");

            thirdCheck = DisplayExecutionTime(() =>
            {
                Sinus.SinusDecimal(2m, 2000000m, 2m);
            });

            Console.WriteLine("SinusFloat VS SinusDouble VS SinusDecimal:\t{0}", FindMinTest(firstCheck, secondCheck, thirdCheck) + Environment.NewLine);
        }
    }
}