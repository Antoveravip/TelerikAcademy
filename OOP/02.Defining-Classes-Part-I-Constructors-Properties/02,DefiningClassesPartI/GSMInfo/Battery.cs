using System;
using System.Collections.Generic;

namespace GSM
{
    public class Battery
    {
        // --- FIELDS --- //
        // Characteristics fields - Homework tasks 1 and 3
        private string model;
        private decimal hoursIdle;
        private decimal hoursTalk;
        private BatteryType batteryType; //Homework task 3

        // --- CONSTRUCTORS --- //
        //Constructors - Homework Task 2  
        public Battery()
            : this(null, 0, 0, BatteryType.None) // Reuse the constructor
        {
        }

        public Battery(BatteryType batteryType)
        {
            this.batteryType = batteryType;
        }

        public Battery(decimal hoursIdle = 0, decimal hoursTalk = 0)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        //Constructor with the full information for the class
        public Battery(string model = null, decimal hoursIdle = 0, decimal hoursTalk = 0, BatteryType batteryType = BatteryType.None)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        // --- PROPERTIES --- //
        //Properties - Homework Tasks 5
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentOutOfRangeException("The model name should be with correct name!");
                }
                else
                {
                    model = value;
                }
            }
        }

        public decimal HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The idle hours should be with correct value!");
                }
                else
                {
                    hoursIdle = value;
                }
            }
        }

        public decimal HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The idle hours should be with correct value!");
                }
                else
                {
                    hoursTalk = value;
                }
            }
        }

        public BatteryType BatteryType
        {
            get { return batteryType; }
            set
            {
                if (Enum.IsDefined(typeof(BatteryType), value))
                {
                    throw new ArgumentOutOfRangeException("The type should be one of following types: LiIon, LiPol, NiMH or NiCd");
                }
                else
                {
                    batteryType = value;
                }
            }
        }
    }
}