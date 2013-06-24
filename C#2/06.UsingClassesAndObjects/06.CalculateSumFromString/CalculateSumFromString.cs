/* Lesson 6 - Using Classes and Objects
 * Homework 6
 * 
 * You are given a sequence of positive integer values 
 * written into a string, separated by spaces. Write a 
 * function that reads these values from given string
 * and calculates their sum.
 * Example:
 * string = "43 68 9 23 318" --> result = 461
 */

using System;

class CalculateSumFromString
{
    static void Main()
    {
        //Test string
        string inputData = "43 68 9 23 318";
        /*
        Console.WriteLine("Enter some numbers with interval: ");
        string inputData = Console.ReadLine();
        */
        int sum = 0;
        string number = "";
        for (int i = 0; i < inputData.Length; i++)
        {
            if (inputData[i] == ' ')
            {
                sum = sum + int.Parse(number);
                number = "";
            }
            else
            {
                number = number + (inputData[i] - '0');
                if (i == inputData.Length - 1)
                {
                    sum = sum + int.Parse(number);
                    number = "";
                }
            }
        }
        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}