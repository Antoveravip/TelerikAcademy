/* Lesson 2 - Primitive Data Types and Variables
 * Homework 14
 * A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, BIC code and 3 
 * credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank
 * account using the appropriate data types and descriptive names.
 */

using System;

class BankAccount
{
    static void Main()
    {
        //Declare the variables
        string firstName;
        string middleName;
        string lastName;
        decimal accountBalance;
        string bankName;
        string iBAN;
        string codeBIC;
        ulong creditCardMasterCard;
        ulong creditCardVISA;
        ulong creditCardAmEx;
        //Initialize the variables
        firstName = "Petar";
        middleName = "Lyubomirov";
        lastName = "Ivanov";
        accountBalance = 11000000m;
        bankName = "Bulgarian National Bank";
        iBAN = "BG80 BNBG 9661 1020 3456 78";
        codeBIC = "BNBGBGSF";
        creditCardMasterCard = 5209968425642697u;
        creditCardVISA = 4929056215124274u;
        creditCardAmEx = 340891938674448u;
        //Print information about that account
        Console.WriteLine("The requested record for this account is:");
        Console.WriteLine(new string('-', 45) +
                          "\nBank: {0}" +
                          "\nIBAN: {1}" +
                          "\nBIC code: {2}" +
                          "\nBalance: {3}" +
                          "\nFirst name: {4}" +
                          "\nMiddle name: {5}" +
                          "\nFamily: {6}" +
                          "\nCredit Cards:\n" +
                          new string('-', 35) +
                          "\nMaster Card: {7}" +
                          "\nVISA: {8}" +
                          "\nAmerican Express: {9}\n",
                          bankName, iBAN, codeBIC, accountBalance, firstName, middleName,
                          lastName, creditCardMasterCard, creditCardVISA, creditCardAmEx);
    }
}