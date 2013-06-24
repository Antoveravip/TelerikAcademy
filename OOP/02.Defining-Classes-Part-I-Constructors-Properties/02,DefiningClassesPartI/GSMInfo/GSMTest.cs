using System;
using System.Collections.Generic;

namespace GSM
{
    class GSMTest
    {
        static void Main()
        {
            //Few instances of the GSM class - Homework Task 7
            Battery firstBattery = new Battery("Nokia", 7, 711, BatteryType.LiIon);
            Display firstDisplay = new Display(3, 65000);
            GSM firstPhone = new GSM("Asha 311", "Nokia", 240, "Pavlov", firstBattery, firstDisplay);

            Battery secondBattery = new Battery("Samsung", 12, 570, BatteryType.LiIon);
            Display secondDisplay = new Display(4, 16000000);
            GSM secondPhone = new GSM("Galaxy S Duos", "Samsung", 420, "Ivanov", secondBattery, secondDisplay);

            Battery thirdBattery = new Battery("LG", 9, 730, BatteryType.LiIon);
            Display thirdDisplay = new Display(4.7, 16000000);
            GSM thirdPhone = new GSM("Optimus 4X", "LG", 650, "Georgiev", thirdBattery, thirdDisplay);

            Battery fourthBattery = new Battery("Sony", 11, 550, BatteryType.LiIon);
            Display fourthDisplay = new Display(5, 16000000);
            GSM fourthPhone = new GSM("Xperia Z", "Sony", 1200, "Stoyanova", fourthBattery, fourthDisplay);

            //Array of instances of the GSM class - Homework Task 7
            GSM[] mobiles = { firstPhone, secondPhone, thirdPhone, fourthPhone};

            //Display the information about the GSMs in the array. - Homework Task 7
            foreach (var mobile in mobiles)
            {
                Console.WriteLine(mobile.ToString());
                Console.WriteLine();
            }

            //Display the information about the static property IPhone4S - Homework Task 7
            Console.WriteLine(GSM.IPhone4S);

            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}