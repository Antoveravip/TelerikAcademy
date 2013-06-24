using System;
using System.Collections.Generic;

namespace GSM
{
    public class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            int longestCall = 0;

            //Instances of the GSM class - Homework Task 12
            Battery battery = new Battery("Nokia", 7, 711, BatteryType.LiIon);
            Display display = new Display(3, 65000);
            GSM mobile = new GSM("Asha 311", "Nokia", 240, "Pavlov", battery, display);

            //Instances of the Call class - Homework Task 12
            Call[] calls = new Call[5];
            calls[0] = new Call(new DateTime(2013, 02, 14, 18, 10, 10), "+359889221611", 125);
            calls[1] = new Call(new DateTime(2013, 02, 14, 18, 13, 15), "+359888998877", 124);
            calls[2] = new Call(new DateTime(2013, 02, 14, 18, 16, 12), "+359887251178", 65);
            calls[3] = new Call(new DateTime(2013, 02, 14, 18, 20, 22), "+359889221611", 88);


            //Add calls - Homework Task 12
            GSM[] mobiles = new GSM[4];
            mobiles[1] = new GSM("Asha 311", "Nokia");

            mobiles[1].AddCall(calls[0]);
            mobiles[1].AddCall(calls[1]);
            mobiles[1].AddCall(calls[2]);
            mobiles[1].AddCall(calls[3]);

            //Display calls information - Homework Task 12
            mobiles[1].ViewCallInfo(mobiles[1].CallHistory);

            //Calculate the total price of the calls in the history with price per min - 0.37 - Homework Task 12
            mobiles[1].ViewCallCost(mobiles[1].CalculateTotalCallCost(0.37M));

            //Finding the longest call from the history - Homework Task 12
            int maxDuration = 0;
            for (int i = 0; i < mobiles[1].CallHistory.Count; i++)
            {                
                if (maxDuration < mobiles[1].CallHistory[i].Duration)
                {
                    maxDuration = mobiles[1].CallHistory[i].Duration;
                    longestCall = i;
                }
            }

            //Removing the longest call from the history- Homework Task 12
            mobiles[1].DeleteCall(mobiles[1].CallHistory[longestCall]);

            ////Displays the information about the remaining calls - Homework Task 12
            mobiles[1].ViewCallInfo(mobiles[1].CallHistory);

            //Calculates the total price again - Homework Task 12
            mobiles[1].ViewCallCost(mobiles[1].CalculateTotalCallCost(0.37m));

            //Clear the call history and print it - Homework Task 12
            mobiles[1].ClearCallHistory();

            //Print call history - Homework Task 12
            mobiles[1].ViewCallInfo(mobiles[1].CallHistory);
        }
    }
}