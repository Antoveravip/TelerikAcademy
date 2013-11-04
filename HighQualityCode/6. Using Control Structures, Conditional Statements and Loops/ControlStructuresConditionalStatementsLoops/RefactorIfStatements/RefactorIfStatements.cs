namespace RefactorIfStatements
{
    using System;
    // For this task I thing than must only reorganize the if statements. 
    // Thats why do not create classes and rewrite method structure.
    private static class RefactorIfStatements
    {
        static void Main()
        {
            // First refactored if statement
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
                else if (potato.IsFresh)
	            {
                    Peel(potato);
	            }
                else
	            {
                    potato = new Potato();
                    Peel(potato);
	            }
            }

            // Second refactored if statement
            bool isYInRange = minY <= y && y <= maxY;
            bool isXInRagne = minX <= x && x <= maxX;

            if (shouldVisitCell && isXInRagne && isYInRange)
            {
                VisitCell();
            }
        }
    }
}