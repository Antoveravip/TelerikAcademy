using System;
using System.Threading;

namespace Timer
{
    class TimerTest
    {
        static void Main()
        {
            int ticksCount = 1000;
            int duration = 5000;
            TimeDelegate timeDelegate = new TimeDelegate(TrialTimeReminder);

            Timer timer = new Timer(ticksCount, duration, timeDelegate);

            Console.WriteLine("Trial time is started for {0} ticks, a tick occurring once every {1} second(s).", ticksCount, duration / 1000);

            Thread timerThread = new Thread(new ThreadStart(timer.TickTack));
            timerThread.Start();
        }

        static void TrialTimeReminder(int remainingTime)
        {
            Console.WriteLine("This trial version expires after: {0} ticks.", remainingTime);
            Console.WriteLine("To have more time - here you can buy it!");
        }
    }
}