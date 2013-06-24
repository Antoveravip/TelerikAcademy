namespace SimpleMathOperation
{
    using System;
    using System.Diagnostics;

    public static class TestThePerformance
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

        public static void Main()
        {
            // Primary test all methods
            AddValue.AddInt(1, 1600000, 2);
            AddValue.AddLong(1L, 1600000L, 2);
            AddValue.AddFloat(1f, 1600000f, 2);
            AddValue.AddDouble(1d, 1600000d, 2);
            AddValue.AddDecimal(1m, 1600000m, 2);
            
            Increment.IncrementInt(1, 800000);
            Increment.IncrementLong(1L, 800000L);
            Increment.IncrementFloat(1f, 800000f);
            Increment.IncrementDouble(1d, 800000d);
            Increment.IncrementDecimal(1m, 800000m);
            
            SubtractValue.SubtractInt(1600000, 1, 2);
            SubtractValue.SubtractLong(1600000L, 1L, 2);
            SubtractValue.SubtractFloat(1600000f, 1f, 2);
            SubtractValue.SubtractDouble(1600000d, 1d, 2);
            SubtractValue.SubtractDecimal(1600000m, 1m, 2);
            
            Decrement.DecrementInt(800000, 1);
            Decrement.DecrementLong(800000L, 1L);
            Decrement.DecrementFloat(800000f, 1f);
            Decrement.DecrementDouble(800000d, 1d);
            Decrement.DecrementDecimal(800000m, 1m);
            
            MultiplyValue.MultiplyInt(1, 1600000, 2);
            MultiplyValue.MultiplyLong(1L, 1600000L, 2L);
            MultiplyValue.MultiplyFloat(1f, 1600000f, 2f);
            MultiplyValue.MultiplyDouble(1d, 1600000d, 2d);
            MultiplyValue.MultiplyDecimal(1m, 1600000m, 2m);
            
            DivideValue.DivideInt(1600000, 1, 2);
            DivideValue.DivideLong(1600000L, 1L, 2L);
            DivideValue.DivideFloat(1600000f, 1f, 2f);
            DivideValue.DivideDouble(1600000d, 1d, 2d);
            DivideValue.DivideDecimal(1600000m, 1m, 2m);
             
            // Secondary test all methods

            Console.WriteLine("Test AddInt VS IncrementInt" + Environment.NewLine + new string('-', 60));

            Console.Write("AddInt Time:\t\t\t");

            TimeSpan firstCheck = DisplayExecutionTime(() =>
                {
                    AddValue.AddInt(1, 800000, 1);
                });


            Console.Write("IncrementInt Time:\t\t");

            TimeSpan secondCheck = DisplayExecutionTime(() =>
            {
                Increment.IncrementInt(1, 800000);
            });

            Console.WriteLine("AddInt VS IncrementInt result:  {0}", firstCheck - secondCheck + Environment.NewLine);

            Console.WriteLine("Test AddDecimal VS IncrementDecimal" + Environment.NewLine + new string('-', 60));

            Console.Write("AddDecimal Time: \t\t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                AddValue.AddDecimal(1m, 800000m, 1);
            });

            Console.Write("IncrementDecimal Time: \t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                Increment.IncrementDecimal(1m, 800000m);
            });

            Console.WriteLine("AddDecimal VS IncrementDecimal result:  {0}", firstCheck - secondCheck + Environment.NewLine);

            Console.WriteLine("Test SubtractInt VS DecrementInt" + Environment.NewLine + new string('-', 60));

            Console.Write("SubtractInt Time:\t\t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                SubtractValue.SubtractInt(800000, 1, 1);
            });


            Console.Write("IncrementInt Time:\t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                Decrement.DecrementInt(800000, 1);
            });

            Console.WriteLine("SubtractInt VS DecrementInt result:     {0}", firstCheck - secondCheck + Environment.NewLine);

            Console.WriteLine("Test SubtractDecimal VS DencrementDecimal" + Environment.NewLine + new string('-', 60));

            Console.Write("SubtractDecimal Time: \t\t\t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                SubtractValue.SubtractDecimal(800000m, 1m, 1m);
            });

            Console.Write("DecrementDecimal Time: t\t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                Decrement.DecrementDecimal(800000m, 1m);
            });

            Console.WriteLine("SubtractDecimal VS DecrementDecimal result:     {0}", firstCheck - secondCheck + Environment.NewLine);

            Console.WriteLine("Test MultiplyInt VS DivideInt" + Environment.NewLine + new string('-', 60));

            Console.Write("MultiplyInt Time: \t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                MultiplyValue.MultiplyInt(1, 1600000, 2);
            });

            Console.Write("DivideInt Time:\t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                DivideValue.DivideInt(1600000, 1, 2);
            });

            Console.WriteLine("MultiplyInt VS DivideInt result:{0}", firstCheck - secondCheck + Environment.NewLine);

            Console.WriteLine("Test MultiplyDecimal VS DivideDecimal" + Environment.NewLine + new string('-', 60));

            Console.Write("MultiplyDecimal Time: \t\t\t\t");

            firstCheck = DisplayExecutionTime(() =>
            {
                MultiplyValue.MultiplyDecimal(1600000m, 1m, 2m);
            });

            Console.Write("DivideDecimal Time: \t\t\t\t");

            secondCheck = DisplayExecutionTime(() =>
            {
                DivideValue.DivideDecimal(1600000m, 1m, 2m);
            });

            Console.WriteLine("SubtractDecimal VS DecrementDecimal result:     {0}", firstCheck - secondCheck + Environment.NewLine);            
        }
    }
}