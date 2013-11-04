namespace RefactoringLoop
{
    using System;

    private static class RefactoringLoop
    {
        static void Main()
        {
            for (int index = 0; index < 100; index++)
            {
                Console.WriteLine(array[index]);
                
                // It seems
                if ((index % 10 == 0) && (array[index] == expectedValue))
                {
                    Console.WriteLine("Value Found");
                }
            }
        }
    }
}