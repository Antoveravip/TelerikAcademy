/* Lesson 2 - Defining-Classes-Part-I-Constructors-Properties
 *  For more information see HomeworksTasks.cs
 */

using System;
using System.Collections.Generic;

namespace GSM
{
    public class GSM
    {
        // --- FIELDS --- //
        //Characteristics fields - Homework Tasks 1
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        //Instances of the class Battery and class Display - Homework Task 1
        private Battery battery = new Battery(null, 0, 0, BatteryType.None);
        private Display display = new Display(0, 0);

        //Static fields for IPhone4S - Homework Tasks 6
        private static Battery iPhone4SBattery = new Battery("Apple", 14, 200, BatteryType.LiIon);
        private static Display iPhone4SDisplay = new Display(3.5, 16000000);
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", 1200, "Jordan", iPhone4SBattery, iPhone4SDisplay);

        //Homework Task 9
        private List<Call> callHistory = new List<Call>();

        // --- CONSTRUCTORS --- //
        //Constructors - Homework Task 2        
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }
        // Reuse the constructor
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
            : this(model, manufacturer, 0, null, null, null)
        {
        }
        //Constructor with the full information for the class
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
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
                    throw new ArgumentOutOfRangeException("The model should be with correct name!");
                }
                else
                {
                    model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentOutOfRangeException("The manufacturer should be with correct name!");
                }
                else
                {
                    manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Please enter correct price");
                }
                else
                {
                    price = value;
                }
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentOutOfRangeException("The owner should be be with correct name!");
                }
                else
                {
                    owner = value;
                }
            }
        }

        //Property for IPhone4S - Homework Tasks 6
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        //Property for call history - Homework Tasks 9
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set
            {
                if (callHistory.Count <= 0)
                {
                    throw new ArgumentOutOfRangeException("The call history is empty!");
                }
                else
                {
                    callHistory.Add(new Call());
                }
            }
        }

        // --- METHODS --- //
        //Override ToString() - Homework Tasks 4
        public override string ToString()
        {
            string batteryInfo = "";
            batteryInfo = String.Format("Model: {0}, Type: {1}, IdleHours: {2} h, TalkHours: {3} h",
            battery.Model, battery.BatteryType, battery.HoursIdle, battery.HoursTalk);

            string displayInfo = "";
            displayInfo = String.Format("Size: {0}\", Colors: {1}", display.Size, display.Colors);

            return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2} BGN\nOwner: {3}\nBattery - {4}\nDisplay - {5}",
                this.Model, this.Manufacturer, this.Price, this.Owner, batteryInfo, displayInfo);
        }

        //Adding call to the calls history - Homework Task 10
        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        //Deleting call from the call history - Homework Task 10
        public void DeleteCall(Call selectedCall)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (selectedCall.StartCallTime == this.callHistory[i].StartCallTime)
                {
                    this.callHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        //Clear all call history - Homework Task 10
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        //Calculates the total price of the calls in the call history - Homework Task 11
        public decimal CalculateTotalCallCost(decimal pricePerMinute)
        {
            decimal totalCallTime = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalCallTime += this.callHistory[i].Duration;
            }
            decimal totalCallCost = (totalCallTime / 60) * pricePerMinute;
            return totalCallCost;
        }

        //View call cost - Homework Task 12
        public void ViewCallCost(decimal currentCallCost)
        {
            Console.WriteLine("The call(s) you check cost you: {0:0.00} BGN", currentCallCost);
        }

        //View call history - Homework Task 12
        public void ViewCallInfo(List<Call> callHistory)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                Console.WriteLine(this.callHistory[i].StartCallTime + " " +
                    this.callHistory[i].DialedNumber + " " + this.callHistory[i].Duration + "s");
            }
        }
    }
}