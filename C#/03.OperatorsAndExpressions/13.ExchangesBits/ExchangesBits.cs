/* Lesson 3 - Operators and Expressions
 * Homework 13
 * Write a program that exchanges bits 3, 4 and 5 with 
 * bits 24, 25 and 26 of given 32-bit unsigned integer.
 */

using System;

class ExchangesBits
{
    static byte k = 3;
    static uint bitsP, bitsQ, maskP, maskQ, modNumber, inputNumber;
    static byte p = 3;
    static byte q = 24;

    static void InputCheck()
    {
        bool check = false;
        string inputData;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out inputNumber);
            if (check == false || inputNumber <= 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                inputNumber = uint.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter 32-bit positive integer number:");
        InputCheck();
        modNumber = inputNumber;
        Console.WriteLine("\nThe entered integer is {0} - ({1})\n", inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(32, '0')));
        //Getting the values of needed positions and assign them to variables
        p = 3;
        q = 24;
        for (int i = 1; i <= k; i++)
        {
            maskP = (uint)(1 << p);
            bitsP = (modNumber & maskP) >> p;
            maskQ = (uint)(1 << q);
            bitsQ = (modNumber & maskQ) >> q;
            if (bitsP == bitsQ)
            {
                p++;
                q++;
            }
            else
            {
                if (bitsP > bitsQ)
                {
                    maskP = ~(1u << p);
                    modNumber = modNumber & maskP;
                    maskQ = (1u << q);
                    modNumber = modNumber | maskQ;
                }
                if (bitsP < bitsQ)
                {
                    maskP = (uint)(1 << p);
                    modNumber = modNumber | maskP;
                    maskQ = ~(1u << q);
                    modNumber = modNumber & maskQ;
                }
                p++;
                q++;
            }
        }
        Console.WriteLine("After exchanging the bits of entered number\n{0} - ({1})\nnew number is\n{2} - ({3})\n", inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(32, '0')), modNumber, (Convert.ToString(modNumber, 2).PadLeft(32, '0')));
    }
}