/* Lesson 2 - Primitive Data Types and Variables
 * Homework 10
 * A marketing firm wants to keep record of its employees.
 * Each record would have the following characteristics – first name, 
 * family name, age, gender (m or f), ID number, unique employee number 
 * (27560000 to 27569999). Declare the variables needed to keep the 
 * information for a single employee using appropriate data types and 
 * descriptive names.
 */

using System;

class FirmRecords
{
    static void Main()
    {
        //Declare the variables
        string firstName;
        string familyName;
        byte age;
        char gender;
        ulong personIDNum;
        uint employeeNum;
        //Initialize the variables
        firstName = "Petar";
        familyName = "Ivanov";
        age = 32;
        gender = 'm';
        personIDNum = 162123456u;
        employeeNum = 27562222u;
        //Display the information for this record
        Console.WriteLine("The requested record for this employee is:");
        Console.WriteLine("Employee number: {5}\nFirst name: {0}\nFamily name: {1}\nAge: {2}\nGender(f/m): {3}\nID number: {4}", firstName, familyName, age, gender, personIDNum, employeeNum);
    }
}