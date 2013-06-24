using System;

class AstrologicalDigits
{
    static void Main()
    {
        int digitSum = 0;
        while (true)
        {
            int inputChar = Console.Read();
            if ((inputChar == -1) || (inputChar == '\n') || (inputChar == '\r'))
            {
                break;
            }
            if (inputChar >= '0' && inputChar <= '9')
            {
                char nextChar = (char)inputChar;
                int digit = nextChar - '0';
                digitSum += digit;                
            }            
        }
        while (digitSum > 9)
        {
            int finalSum = 0;
            while (digitSum > 0)
            {
                int lastDigit = digitSum % 10;
                finalSum += lastDigit;
                digitSum = digitSum / 10;
            }
            digitSum = finalSum;
        }
        Console.WriteLine(digitSum);
    }
}