/* Lesson 3 - Operators and Expressions
 * Homework 14*
 * Write a program that exchanges bits {p, p+1, …, p+k-1) with
 * bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
 */

using System;

class ExchangesMoreBits
{
    static byte k, p, q;
    static uint inputNumber, bitP, bitQ, maskP, maskQ, modifNumber;
    static bool check;
    static string inputData;

    static void Main()
    {
        Console.Write("Enter positive integer number (32-bit):");
        check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = uint.TryParse(inputData, out inputNumber);
            if (check == false || inputData == "0" || inputData.Length > 10)
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
        //Limits for k will be bits of number / number of ranges. In this case limits for k are 0 and 32/2=16
        //Limit 0 will be disabled in input check.
        check = false;
        while (check != true)
        {
            Console.Write("Enter how many bits you want to exchange:");
            inputData = Console.ReadLine();
            check = byte.TryParse(inputData, out k);
            if (inputData == null || inputData == String.Empty || check == false || inputData == "0")
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                k = byte.Parse(inputData);
                if (k > 16)
                {
                    check = false;
                    Console.Write("Not correct value! Please enter again:");
                }
                else
                {
                    check = true;
                }
            }
        }
        //Limit value for k, when p and q are by default 1 and 17! 
        if (k == 16)
        {
            p = 1;
            q = 17;
        }
        else
        {
            Console.Write("Enter first bit position from a range [p - p+k-1].Keep in mind!\nEntered value must be number lesser than 32 - 2*k! p = ");
            check = false;
            while (check != true)
            {
                inputData = Console.ReadLine();
                check = byte.TryParse(inputData, out p);
                if (inputData == null || inputData == String.Empty || check == false)
                {
                    check = false;
                    Console.Write("Not correct bit position! Please enter again:");
                }
                else
                {
                    p = byte.Parse(inputData);
                    if (p > (32 - 2 * k))
                    {
                        check = false;
                        Console.Write("Not correct bit position! Please enter again:");
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            Console.Write("Enter second bit position from a range [q - q+k-1] - q:");
            check = false;
            while (check != true)
            {
                inputData = Console.ReadLine();
                check = byte.TryParse(inputData, out q);
                if (inputData == null || inputData == String.Empty || check == false || inputData == "0")
                {
                    check = false;
                    Console.Write("Not correct bit position! Please enter again:");
                }
                else
                {
                    q = byte.Parse(inputData);
                    if (q < (p + k) || q > ((32 - k) + p) || q >= 32)
                    {
                        check = false;
                        Console.Write("Not correct bit position! Please enter again:");
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
        }
        Console.WriteLine("\nThe entered integer is {0} - ({1})\n", inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(32, '0')));
        Console.WriteLine("Your choice is to exchange value of bits from {0} to {1},", p, (p + k - 1));
        Console.WriteLine("with value of bits from {0} to {1}", q, (q + k - 1));
        modifNumber = inputNumber;
        for (int i = 1; i <= k; i++)
        {
            maskP = (uint)(1 << p);
            bitP = (modifNumber & maskP) >> p;
            maskQ = (uint)(1 << q);
            bitQ = (modifNumber & maskQ) >> q;
            if (bitP == bitQ)
            {
                p++;
                q++;
            }
            else
            {
                if (bitP > bitQ)
                {
                    maskP = ~(1u << p);
                    modifNumber = modifNumber & maskP;
                    maskQ = (1u << q);
                    modifNumber = modifNumber | maskQ;
                }
                if (bitP < bitQ)
                {
                    maskP = (uint)(1 << p);
                    modifNumber = modifNumber | maskP;
                    maskQ = ~(1u << q);
                    modifNumber = modifNumber & maskQ;
                }
                p++;
                q++;
            }
        }
        Console.WriteLine("\nThe entered integer was {0} - ({1})\n", inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(32, '0')));
        Console.WriteLine("\nAfter exchanging the bits - new number is {0}\n- ({1})\n", modifNumber, (Convert.ToString(modifNumber, 2).PadLeft(32, '0')));
    }
}