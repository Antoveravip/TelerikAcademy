/* Lesson 1 - Introduction to Programming
 * Homework 12 *
 * Write a program to read your age from the console and print how old you will be after 10 years.
 */

using System;
using System.Globalization;

class ShowsOurAgeAfterTenYears
{
    static void Main()
    {
        string inputData;
        DateTime checkYear;
        bool checkAll = false;
        do
        {
            Console.Write("Enter your birth year:");
            inputData = Console.ReadLine();
            bool checkFormat = true;
            foreach (char c in inputData)
            {
                if (c < '0' || c > '9')
                {
                    checkFormat = false;
                }
            }
            bool inputCheck = DateTime.TryParse(inputData, out checkYear);
            checkAll = checkFormat && (inputData.Length <= 4) && (inputData != null && inputData != String.Empty);
            if (checkAll != true)
            {
                Console.WriteLine("You didn't enter correct your birth year!");
            }
            else
            {
                checkAll = true;
            }
        }
        while (checkAll != true);
        int birthYear = int.Parse(inputData);
        DateTime thisYear = DateTime.Now;
        int currentYear = thisYear.Year;
        int currentAge = currentYear - birthYear;
        Console.WriteLine();
        if (currentAge >= 0 && currentAge < 125)
        {
            Console.WriteLine("Your current age is " + currentAge + " years");
        }
        if (currentAge < 0)
        {
            Console.WriteLine("Please, be serious - or you come back when you got born!");
        }
        if (currentAge > 125)
        {
            Console.WriteLine("This little program is not made for biblical or mythical characters!");
        }
        Console.WriteLine();
        DateTime ageAfter = thisYear.AddYears(10);
        int futureAge = ageAfter.Year - birthYear;
        if (futureAge > 0 && futureAge < 122)
        {
            Console.WriteLine("After ten years you will be on " + futureAge + " years. Wish you all the best many more years!");
        }
        if (futureAge == 0)
        {
            Console.WriteLine("After ten years you may be born and will be below a year. Wish you all the best. One good, happy and long life!");
        }
        if (futureAge > 122 && futureAge < 130)
        {
            Console.WriteLine("After ten years you will be on " + futureAge + " You can be candidate in Guinness book for one of the oldest people on that planet. Wish you all the best!");
        }
        if (futureAge > 130)
        {
            Console.WriteLine("My God, man! You still here! Duncan MacLeod? Or another so older man. If you are so old - yes, you definately need program like this to calculate your age. After ten years you will be on " + futureAge + " If you are Duncan - keep your head. If you are other - keep living. Anyway wish you all the best!");
        }
    }
}