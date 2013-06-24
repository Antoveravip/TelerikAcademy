/* Lesson 4 - Methods
 * Homework 8
 * 
 * Write a method that adds two positive integer numbers represented
 * as arrays of digits (each array element arr[i] contains a digit; 
 * the last digit is kept in arr[0]). Each of the numbers that will 
 * be added could have up to 10 000 digits.
 */

using System;

class SumsDigitsArrays
{
    static void Main()
    {
        //Test arrays - numbers 678241027986531 + 83245798 = 678241111232329
        byte[] firstNumArray = { 1, 3, 5, 6, 8, 9, 7, 2, 0, 1, 4, 2, 8, 7, 6 };
        byte[] secNumArray = { 8, 9, 7, 5, 4, 2, 3, 8 };
        /*
       //Reads numbers from the console
       Console.WriteLine("Enter the first number.");
       string firstInput = Console.ReadLine();

       Console.WriteLine("Enter the second number.");
       string secondInput = Console.ReadLine();

       int maxLength = Math.Max(firstInput.Length, secondInput.Length);

       // Create arrays for entered numbers.
       byte[] firstNumArray = new byte[firstInput.Length];
       byte[] secNumArray = new byte[secondInput.Length];

       // Assign element values of arrays
       for (int i = 0; i < firstInput.Length; i++)
       {
           firstNumArray[i] = (byte)(firstInput[firstInput.Length - 1 - i] - '0');
       }

       for (int i = 0; i < secondInput.Length; i++)
       {
           secNumArray[i] = (byte)(secondInput[secondInput.Length -1 - i] - '0');
       }
        */
        SumOfArrays(firstNumArray, secNumArray);
    }

    static void SumOfArrays(byte[] firstArray, byte[] secArray)
    {
        byte[] sumArray = new byte[Math.Max(firstArray.Length, secArray.Length) + 1];
        byte addOne = 0;
        byte current = 0;
        int maxLength = Math.Max(firstArray.Length, secArray.Length);
        int minLength = Math.Min(firstArray.Length, secArray.Length);
        for (int i = 0; i < minLength; i++)
        {
            current = (byte)(firstArray[i] + secArray[i] + addOne);
            if (current >= 10)
            {
                sumArray[i] = (byte)(current % 10);
                addOne = 1;
            }
            else
            {
                sumArray[i] = current;
                addOne = 0;
            }
            if (i + 1 == minLength)
            {
                for (int j = i + 1; j < maxLength; j++)
                {
                    if (firstArray.Length > secArray.Length)
                    {
                        current = (byte)(firstArray[j] + addOne);
                        if (current >= 10)
                        {
                            sumArray[j] = (byte)(current % 10);
                            addOne = 1;
                        }
                        else
                        {
                            sumArray[j] = current;
                            addOne = 0;
                        }
                    }
                    else
                    {
                        current = (byte)(secArray[j] + addOne);
                        if (current >= 10)
                        {
                            sumArray[j] = (byte)(current % 10);
                            addOne = 1;
                        }
                        else
                        {
                            sumArray[j] = current;
                            addOne = 0;
                        }
                    }
                    if (j + 1 == maxLength && addOne == 1)
                    {
                        sumArray[j + 1] = addOne;
                    }
                }
            }
        }
        Array.Reverse(sumArray);

        for (int i = 0; i < sumArray.Length; i++)
        {
            if (i == 0 && i == sumArray[i])
            {
            }
            else
            {
                Console.Write(sumArray[i]);
            }
        }
        Console.WriteLine();
    }
}