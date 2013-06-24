namespace Methods
{
    using System;

    public static class Methods
    {
        public static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            // Heron's Formula for the area of a triangle
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * 
                                   (semiPerimeter - sideA) * 
                                   (semiPerimeter - sideB) *
                                   (semiPerimeter - sideC));

            return area;
        }

        public static string DigitName(int digit)
        {
            string digitName = "";

            switch (digit)
            {
                case 0: { digitName = "zero"; break; }
                case 1: { digitName = "one"; break; }
                case 2: { digitName = "two"; break; }
                case 3: { digitName = "three"; break; }
                case 4: { digitName = "four"; break; }
                case 5: { digitName = "five"; break; }
                case 6: { digitName = "six"; break; }
                case 7: { digitName = "seven"; break; }
                case 8: { digitName = "eight"; break; }
                case 9: { digitName = "nine"; break; }
                default: { throw new ArgumentException("Not a digit! Digits are from 0 to 9!"); }
            }

            return digitName;
        }

        public static int FindMaxValue(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentException("Not valid input. Not initialized array data!");
            }
            if (elements.Length == 0)
            {
                throw new ArgumentException("Not valid input. Empty array data!");
            }

            int maxValue = int.MinValue;

            for (int index = 1; index < elements.Length; index++)
            {
                if (elements[index] > maxValue)
                {
                    maxValue = elements[index];
                }
            }

            return maxValue;
        }

        public static void NumericFormatString(object number, string format)
        {
            string formated = "";
            format = format.ToLower();

            switch (format)
            {
                case "c": { formated = "{0:C2}"; break; }
                case "d": { formated = "{0:D2}"; break; }
                case "e": { formated = "{0:e2}"; break; }
                case "f": { formated = "{0:F2}"; break; }
                case "g": { formated = "{0:G}"; break; }
                case "n": { formated = "{0:N2}"; break; }
                case "p": { formated = "{0:P0}"; break; }
                case "%": { formated = "{0:P0}"; break; }
                case "r": { formated = "{0,8}"; break; }
                case "x": { formated = "{0:X}"; break; }
                default:
                    {
                        throw new FormatException("Unknown format specifier!");
                    }
            }

            Console.WriteLine(formated, number);
        }

        private static bool IsPointsEqual(double x1, double y1, double x2, double y2)
        {
            bool isPointEqual = (x1 == x2 && y1 == y2);

            return isPointEqual;
        }

        public static bool IsHorizontalLine(double x1, double y1, double x2, double y2)
        {
            bool isLineHorizontal = false;

            if (IsPointsEqual(x1, y1, x2, y2))
            {
                throw new ArgumentException("This points can't define a line.");
            }

            isLineHorizontal = (y1 == y2);

            return isLineHorizontal;
        }

        public static bool IsVerticalLine(double x1, double y1, double x2, double y2)
        {
            bool isLineVertical = false;

            if (IsPointsEqual(x1, y1, x2, y2))
            {
                throw new ArgumentException("This points can't define a line.");
            }
            isLineVertical = (x1 == x2);

            return isLineVertical;
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(DigitName(5));
            
            Console.WriteLine(FindMaxValue(5, -1, 3, 2, 14, 2, 3));
            
            NumericFormatString(1.3, "f");
            NumericFormatString(0.75, "%");
            NumericFormatString(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            bool isLineHorizontal = IsHorizontalLine(3, -1, 3, 2.5);
            Console.WriteLine("Horizontal? " + isLineHorizontal);

            bool isLineVertical = IsVerticalLine(3, -1, 3, 2.5);            
            Console.WriteLine("Vertical? " + isLineVertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}