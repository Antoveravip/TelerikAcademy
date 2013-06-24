using System;

class DancingBits
{
    static void Main()
    {
        /*int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string allBits = "";

        for (int i = 1; i <= n; i++)
        {
            int nums = int.Parse(Console.ReadLine());
            string numbers = Convert.ToString(nums, 2);
            allBits = allBits + numbers;
        }
        allBits = "*" + allBits + "*";
        //Checks about sequences of ones
        string ones = new string('1', k);
        int onesCount = 0;
        int index = -1;
        while (true)
        {
            index = allBits.IndexOf(ones, index+1);
            if (index == -1)
            {
                break;
            }
            if (allBits[index-1] != allBits[index] &&
                allBits[index + k-1] != allBits[index + k])
            {
                onesCount++;
            }            
        }
        //Checks about sequences of zeros
        string zeros = new string('0', k);
        int zerosCount = 0;
        index = -1;
        while (true)
        {
            index = allBits.IndexOf(zeros, index + 1);
            if (index == -1)
            {
                break;
            }
            if (allBits[index - 1] != allBits[index] &&
                allBits[index + k - 1] != allBits[index + k])
            {
                zerosCount++;
            }
        }
        Console.WriteLine(onesCount+zerosCount);*/

        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
         
        int kSequenceCount = 0;
        int length = 0;
        int lastBit = -1;

        for (int i = 1; i <= n; i++)
        {
            int nums = int.Parse(Console.ReadLine());
            bool oneFound = false;
            for (int bitPos = 31; bitPos >= 0; bitPos--)
            {
                int bitValue = (nums >> bitPos) & 1;
                if (bitValue == 1)
                {
                    oneFound = true;
                }
                if (oneFound)
                {
                    if (lastBit == bitValue)
                    {
                        length++;
                    }
                    else
                    {
                        if (length == k)
                        {
                            kSequenceCount++;
                        }
                        length = 1;
                    }
                    lastBit = bitValue;
                }
            }
        }
        if (length == k)
        {
            kSequenceCount++;
        }
        Console.WriteLine(kSequenceCount);
    }
}