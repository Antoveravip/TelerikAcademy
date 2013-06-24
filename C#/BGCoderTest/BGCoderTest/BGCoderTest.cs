using System;

namespace BGCoderTest
{
    class BGCoderTest
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit;
            int digit;
            string fDig = "", sDig = "", thDig = "", fourDigit = "", output = "";
            int position = 0;
            if (number == 0 || number == 3)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (number > 0)
                {
                    position++;
                    lastDigit = number % 10;
                    digit = lastDigit;
                    number = number / 10;
                    if (position == 1)
                    {
                        switch (digit)
                        {
                            case 0: { fDig = ""; break; }
                            case 1: { fDig = "0"; break; }
                            case 2: { fDig = "00"; break; }
                            case 3: { fDig = "000"; break; }
                            case 4: { fDig = "01"; break; }
                            case 5: { fDig = "1"; break; }
                            case 6: { fDig = "10"; break; }
                            case 7: { fDig = "100"; break; }
                            case 8: { fDig = "1000"; break; }
                            case 9: { fDig = "02"; break; }
                            default:
                                break;
                        }
                    }
                    if (position == 2)
                    {
                        switch (digit)
                        {
                            case 0: { sDig = ""; break; }
                            case 1: { sDig = "2"; break; }
                            case 2: { sDig = "22"; break; }
                            case 3: { sDig = "222"; break; }
                            case 4: { sDig = "23"; break; }
                            case 5: { sDig = "3"; break; }
                            case 6: { sDig = "32"; break; }
                            case 7: { sDig = "322"; break; }
                            case 8: { sDig = "3222"; break; }
                            case 9: { sDig = "24"; break; }
                            default:
                                break;
                        }
                    }
                    if (position == 3)
                    {
                        switch (digit)
                        {
                            case 0: { thDig = ""; break; }
                            case 1: { thDig = "4"; break; }
                            case 2: { thDig = "44"; break; }
                            case 3: { thDig = "444"; break; }
                            case 4: { thDig = "45"; break; }
                            case 5: { thDig = "5"; break; }
                            case 6: { thDig = "54"; break; }
                            case 7: { thDig = "544"; break; }
                            case 8: { thDig = "5444"; break; }
                            case 9: { thDig = "46"; break; }
                            default:
                                break;
                        }
                    }
                    if (position == 4)
                    {
                        switch (digit)
                        {
                            case 0: { fourDigit = ""; break; }
                            case 1: { fourDigit = "6"; break; }
                            case 2: { fourDigit = "66"; break; }
                            case 3: { fourDigit = "666"; break; }
                            case 4: { fourDigit = "67"; break; }
                            /*case 5: { fourDigit = "7"; break; }
                            case 6: { fourDigit = "76"; break; }
                            case 7: { fourDigit = "766"; break; }
                            case 8: { fourDigit = "7666"; break; }
                            case 9: { fourDigit = "68"; break; }*/
                            default:
                                break;
                        }
                    }
                }
                output = fourDigit + thDig + sDig + fDig;
                Console.WriteLine(output);
            }
        }
    }
}