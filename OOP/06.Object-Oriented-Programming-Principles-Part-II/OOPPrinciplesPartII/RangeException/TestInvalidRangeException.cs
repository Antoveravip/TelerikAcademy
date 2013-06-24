using System;
using System.Globalization;

namespace RangeException
{
    class TestInvalidRangeException
    {
        private const string DateFormat = "d.M.yyyy";

        static void Main()
        {
            int start = 1;
            int end = 100;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            try
            {
                int number = CheckInputInteger(start, end);
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine("{0}\nRange: [{1}...{2}]", ire.Message, ire.Start, ire.End);
            }

            try
            {
                DateTime date = CheckInputDate(startDate, endDate);
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine("{0}\nRange: [{1} - {2}]", ire.Message, ire.Start.ToString(DateFormat), ire.End.ToString(DateFormat));
            }
        }

        private static int CheckInputInteger(int start, int end)
        {
            int number;
            string value;

            do
            {
                Console.Write("Enter an integer in the range [{0}...{1}]: ", start, end);
                value = Console.ReadLine();
            }
            while (!int.TryParse(value, out number));

            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end);
            }
            else
            {
                Console.WriteLine("This value {0} is valid number in range [{1}...{2}]", number, start, end);
            }

            return number;
        }

        private static DateTime CheckInputDate(DateTime start, DateTime end)
        {
            DateTime date;
            string value;

            do
            {
                Console.Write("Enter a date in the range [{0} - {1}]: ", start.ToString(DateFormat), end.ToString(DateFormat));
                value = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(value, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date));

            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>(start, end);
            }
            else
            {
                Console.WriteLine("This value {0} is valid date in range [{1}...{2}]", date.ToString("d"), start.ToString("d"), end.ToString("d"));
            }
            return date;
        }
    }
}