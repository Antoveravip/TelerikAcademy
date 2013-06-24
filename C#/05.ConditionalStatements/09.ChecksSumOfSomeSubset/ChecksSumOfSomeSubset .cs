/* Lesson 5 - Conditional Statements
 * Homework 9
 * We are given 5 integer numbers. Write a program that
 * checks if the sum of some subset of them is 0. 
 * Example: 3, -2, 1, 1, 8 --> 1+1-2=0.
 */

using System;

class ChecksSumOfSomeSubset
{
    static decimal[] sequence = new decimal[5];
    static decimal number, sum = 0;
    static byte index, count = 0;
    static string inputData;

    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = decimal.TryParse(inputData, out number);
            if (check == false || number == 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = decimal.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter the number:");
            InputCheck();
            sequence[i] = number;
        }
        //Check whole sequence
        sum = sequence[0] + sequence[1] + sequence[2] + sequence[3] + sequence[4];
        if (sum == 0)
        {
            Console.WriteLine("The sum of whole sequence {0}, {1}, {2}, {3}, {4} is {5}", sequence[0], sequence[1], sequence[2], sequence[3], sequence[4], sum);
        }
        sum = 0;
        for (index = 0; index < sequence.Length; index++)
        {
            //Calculate subsets of two numbers 
            for (int i = index + 1; i < sequence.Length; i++)
            {
                sum = sequence[index] + sequence[i];
                if (sum == 0)
                {
                    Console.WriteLine("The sum of subset {0}, {1} is {2}", sequence[index], sequence[i], sum);
                    count++;
                }
                //Calculate subsets of three numbers 
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    sum = sum + sequence[j];
                    if (sum == 0)
                    {
                        Console.WriteLine("The sum of subset {0}, {1}, {2} is {3}", sequence[index], sequence[i], sequence[j], sum);
                        count++;
                    }
                    //Calculate subsets of four numbers 
                    for (int k = j + 1; k < sequence.Length; k++)
                    {
                        sum = sum + sequence[k];
                        if (sum == 0)
                        {
                            Console.WriteLine("The sum of subset {0}, {1}, {2}, {3} is {4}", sequence[index], sequence[i], sequence[j], sequence[k], sum);
                            count++;
                        }
                        sum = 0;
                    }
                }
            }
        }
        Console.WriteLine("\nThe sequence {0}, {1}, {2}, {3}, {4}\nhave {5} subset which sum is 0", sequence[0], sequence[1], sequence[2], sequence[3], sequence[4], count);
    }
}