/* Lesson 4 - Console Input Output
 * Homework 3
 * A company has name, address, phone number, fax number, web site and manager.
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager
 * and prints them on the console.
 */

using System;

class CompanyInfo
{
    static string companyName, address, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerPhoneNumber, inputManagerAge;
    static byte managerAge;

    static void Main()
    {
        bool check = false;
        // Do some, but not all needed checks
        do
        {
            Console.Write("Enter company name:");
            companyName = Console.ReadLine();
            if ((companyName.Length < 3) || (companyName == String.Empty))
            {
                check = false;
                Console.WriteLine("Please, enter correct company name:");
            }
            else
            {
                check = true;
            }
        }
        while (check != true);
        check = false;
        while (check != true)
        {
            Console.Write("Enter company address:");
            address = Console.ReadLine();
            if (address.Length < 20 || address == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct company address:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter phone number:");
            phoneNumber = Console.ReadLine();
            if (phoneNumber.Length < 7 || phoneNumber == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct company phone:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter fax number:");
            faxNumber = Console.ReadLine();
            if (faxNumber.Length < 7 || faxNumber == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct company fax:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter company website:");
            webSite = Console.ReadLine();
            if (webSite.Length < 7 || webSite == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct company website:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter manager first name:");
            managerFirstName = Console.ReadLine();
            if (managerFirstName.Length < 2 || managerFirstName == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct manager first name:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter manager last name:");
            managerLastName = Console.ReadLine();
            if (managerLastName.Length < 3 || managerLastName == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct manager last name:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        while (check != true)
        {
            Console.Write("Enter manager phone number:");
            managerPhoneNumber = Console.ReadLine();
            if (managerPhoneNumber.Length < 7 || managerPhoneNumber == String.Empty)
            {
                check = false;
                Console.WriteLine("Please, enter correct manager phone number:");
            }
            else
            {
                check = true;
            }
        }
        check = false;
        string inputManagerAge;
        while (check != true)
        {
            Console.Write("Enter manager age:");
            inputManagerAge = Console.ReadLine();
            if (byte.TryParse(inputManagerAge, out managerAge))
            {
                managerAge = byte.Parse(inputManagerAge);
                check = true;
            }
            else
            {
                Console.WriteLine("Not correct manager age: {0}", inputManagerAge);

            }
        }
        Console.Clear();
        string managerName = managerFirstName + " " + managerLastName;
        //For align we check wich string is Longest
        decimal firstLength = Math.Max(address.Length, companyName.Length);
        decimal secongLength = Math.Max(webSite.Length, managerName.Length);
        decimal strMaxLength = Math.Max(firstLength, secongLength);
        int alignLenght = Console.WindowWidth - 1;
        int alignRight = Console.WindowWidth - (int)strMaxLength - 1;
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n\n", companyName.PadLeft(alignRight + companyName.Length, ' '), address.PadLeft(alignRight + address.Length, ' '), phoneNumber.PadLeft(alignRight + phoneNumber.Length, ' '), faxNumber.PadLeft(alignRight + faxNumber.Length, ' '), webSite.PadLeft(alignRight + webSite.Length, ' '), managerName.PadLeft(alignRight + managerName.Length, ' '));
        Console.WriteLine("\tDear colleagues,\n\n   I am glad to share with you that our company surpassed the expected\nfinancial results. At the end of the month our company  {0},\norganized a three-day holiday for the whole team at a ski resort. This is a\nsmall gesture of appreciation for your big effort and dedication.\n   Furthermore, each of you will get a proper annual premium.\n\n   I wish you all the best! We never get too old to do the best!\n", companyName);
        Console.WriteLine("   Best regards\n   Your {2} years old manager\n   {0} {1}\n   {3}\n", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        Console.WriteLine(new string('-', Console.WindowWidth));
    }
}