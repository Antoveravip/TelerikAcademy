/* Lesson 3 - Operators and Expressions
 * Homework 12
 * We are given integer number n, value v (v=0 or 1) and a position p.
 * Write a sequence of operators that modifies n to hold the value v
 * at the position p from the binary representation of n.
 * Example:
 * n = 5 (00000101), p=3, v=1 --> 13 (00001101)
 * n = 5 (00000101), p=2, v=0 --> 1 (00000001)
 */

using System;

class SetTheBitAtPosition
{
    static int inputNumber, number;

    static void InputCheck()
    {
        bool check = false;
        string inputData;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = int.TryParse(inputData, out number);
            if (check == false || number < 0)
            {
                check = false;
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                number = int.Parse(inputData);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter integer number:");
        InputCheck();
        inputNumber = number;
        Console.Write("Enter the value of the bit(1 or 0):");
        int inputBitValue;
        bool checkByte;
        do
        {
            inputBitValue = int.Parse(Console.ReadLine());
            checkByte = (inputBitValue == 0) || (inputBitValue == 1);
            if (checkByte != true)
            {
                Console.Write("The entered value is not correct bit value.\nEnter the value of the bit(1 or 0):");
            }
        }
        while (checkByte != true);
        Console.Write("Enter the wanted position to change the bit value:");
        InputCheck();
        int inputPosition = number;
        int mask = 1 << inputPosition;
        int result = inputNumber & mask;
        int currentValue = result >> inputPosition;
        if (currentValue == inputBitValue)
        {
            Console.WriteLine("The bit of position {0} of entered integer {1} ({2}) has value={3}\nNo change has been made! The number still is {1}", inputPosition, inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(8, '0')), currentValue);
        }
        else
        {
            if (currentValue < inputBitValue)
            {
                result = inputNumber | mask;
                Console.WriteLine("The bit of position {0} of entered integer {1} ({2}) has value={3}\nValue was changed to {4}! The number now is {5} ({6})", inputPosition, inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(8, '0')), currentValue, inputBitValue, result, (Convert.ToString(result, 2).PadLeft(8, '0')));
            }
            if (currentValue > inputBitValue)
            {
                mask = ~(1 << inputPosition);
                result = inputNumber & mask;
                Console.WriteLine("The bit of position {0} of entered integer {1} ({2}) has value={3}\nValue was changed to {4}! The number now is {5} ({6})", inputPosition, inputNumber, (Convert.ToString(inputNumber, 2).PadLeft(8, '0')), currentValue, inputBitValue, result, (Convert.ToString(result, 2).PadLeft(8, '0')));
            }
        }
    }
}