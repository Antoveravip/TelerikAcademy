namespace Refactoring.Homework.FirstTask
{
    using System;

    public class BoolExtension
    {
        // This constant is not used anywhere! For further refactoring we can delete it.
        private const int MaxCount = 6;

        public static void Main()
        {
            BoolExtension.BoolToString instance = new BoolExtension.BoolToString();
            instance.PrintBoolValue(true);
        }

        // This inner class is meaningless. For further refactoring we can get out the method and delete the class.
        public class BoolToString
        {
            public void PrintBoolValue(bool boolVariable)
            {
                // This string variable is meaningless. For further refactoring we can replace the code with:
                /*
                Console.WriteLine(oolVariable.ToString());
                */
                string boolValueAsString = boolVariable.ToString();
                Console.WriteLine(boolValueAsString);
            }
        }
    }
}