using System;
using System.Text;

class SevenSegmentDigits
{
    static int[] inputValue;
    static int[] outputValue;
    static int[] digits;
    static byte N;
    static StringBuilder consolePrint;

    static void Main(string[] args)
    {
        consolePrint = new StringBuilder(100000);
        digits = new int[10];

        digits[0] = Convert.ToInt32("1111110", 2);
        digits[1] = Convert.ToInt32("0110000", 2);
        digits[2] = Convert.ToInt32("1101101", 2);
        digits[3] = Convert.ToInt32("1111001", 2);
        digits[4] = Convert.ToInt32("0110011", 2);
        digits[5] = Convert.ToInt32("1011011", 2);
        digits[6] = Convert.ToInt32("1011111", 2);
        digits[7] = Convert.ToInt32("1110000", 2);
        digits[8] = Convert.ToInt32("1111111", 2);
        digits[9] = Convert.ToInt32("1111011", 2);

        N = byte.Parse(Console.ReadLine());

        inputValue = new int[N];
        outputValue = new int[N];
        long result = 1;
        for (int i = 0; i < N; i++)
        {
            inputValue[i] = Convert.ToInt32(Console.ReadLine(), 2);
            result *= Variants(inputValue[i]);
        }
        Console.WriteLine(result);
        CheckValue(0);
        Console.Write(consolePrint);
    }

    public static long Variants(int val)
    {
        long result = 0;
        for (int i = 0; i < 10; i++)
        {
            if (((val & digits[i]) == val))
            {
                result++;
            }
        }
        return result;
    }

    public static void CheckValue(int con)
    {
        if (con == N)
        {
            for (int i = 0; i < N; i++)
            {
                consolePrint.Append(outputValue[i]);
            }
            consolePrint.AppendLine();
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                if (((digits[i] & inputValue[con]) == inputValue[con]))
                {
                    outputValue[con] = i;
                    CheckValue(con + 1);
                }
            }
        }
    }
}