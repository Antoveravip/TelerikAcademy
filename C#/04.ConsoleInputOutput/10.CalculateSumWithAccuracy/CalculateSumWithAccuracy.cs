/* Lesson 4 - Console Input Output
 * Homework 10
 * Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */

using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        decimal sequenceMember = 1;
        decimal sum;
        decimal accuracy = 0.001m;
        decimal memberSum = 1;
        Console.WriteLine("The sequence is:");
        for (sum = 1; (sum - memberSum) <= accuracy; sum ++)
        {
            sequenceMember = 1 / sum;
            Console.Write("{0}, ", sequenceMember);
            memberSum = sequenceMember + sum;
         }
        Console.WriteLine(" and the sum of members with accuracy of 0.001 is: {0}", memberSum);
    }
}