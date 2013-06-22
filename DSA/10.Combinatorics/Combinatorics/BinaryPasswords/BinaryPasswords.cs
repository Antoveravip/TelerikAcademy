namespace BinaryPasswords
{
    using System;

    public static class BinaryPasswords
    {
        public static void Main()
        {
            string input = string.Empty;
            input = Console.ReadLine();
            int count = 0;
            long possibility = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    count++;
                    possibility *= 2;
                }
            }

            if (count == 0)
            {
                possibility = 1;
            }

            Console.WriteLine(possibility);
        }
    }
}