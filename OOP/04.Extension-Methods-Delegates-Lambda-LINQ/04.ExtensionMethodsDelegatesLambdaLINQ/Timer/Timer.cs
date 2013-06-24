/* Home work task 7 and 8
 * 
 * Using delegates write a class Timer that has can execute 
 * certain method at each t seconds.
 */

using System;
using System.Threading;

namespace Timer
{
    // Declaration of a delegate
    public delegate void TimeDelegate(int tick);

    public class Timer
    {
        // --- FIELDS --- //
        private int ticksCount;
        private int duration;
        private TimeDelegate repeat;

        //--- PROPERTIES ---/
        public int TicksCount
        {
            get { return this.ticksCount; }
        }

        public int Duration
        {
            get { return this.duration; }
        }
        // --- CONSTRUCTORS --- //
        public Timer(int ticksCount, int duration, TimeDelegate repeat)
        {
            this.ticksCount = ticksCount;
            this.duration = duration;
            this.repeat = repeat;
        }
        // --- METHODS --- //
        public void TickTack()
        {
            int ticks = this.ticksCount;
            while (ticks > 0)
            {
                Thread.Sleep(this.duration);
                ticks--;
                this.repeat(ticks);
            }
        }
    }
}