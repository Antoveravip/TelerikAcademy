using System;
using System.Globalization;

class NextDate
{
    static void Main()
    {
        //Input
        int inputDay = int.Parse(Console.ReadLine());
        int inputMonth = int.Parse(Console.ReadLine());
        int inputYear = int.Parse(Console.ReadLine());

        //Calculations
        DateTime inputDate = new DateTime(inputYear, inputMonth, inputDay);
        DateTime nextDate = inputDate.AddDays(1);
        string format = "d.M.yyyy";

        //Output
        Console.WriteLine(nextDate.ToString(format));
    }
}