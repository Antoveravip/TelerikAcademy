using System;

namespace GSM
{
    public class Call
    {
        // --- FIELDS --- //
        //Characteristics fields - Homework Task 8
        private DateTime startCallTime = new DateTime();
        private string dialedNumber;
        private int duration = 0;

        // --- CONSTRUCTORS --- //
        //Constructors - Homework Task 8 
        public Call()
        {
        }

        public Call(string dialedNumber)
        {
            this.dialedNumber = dialedNumber;
        }

        public Call(DateTime startCallTime, string dialedNumber, int duration)
        {
            this.startCallTime = startCallTime;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        // --- PROPERTIES --- //
        //Properties - Homework Task 8
        public DateTime StartCallTime
        {
            get { return startCallTime; }
            set { value = this.startCallTime; }
        }

        public string DialedNumber
        {
            get { return dialedNumber; }
            set { value = this.dialedNumber; }
        }

        public int Duration
        {
            get { return duration; }
            set { value = this.duration; }
        }
    }
}