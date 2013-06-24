/* Lesson 11 - Dynamic Programming
 * Homework 2
 * 
 * Write a program to calculate the "Minimum Edit Distance" (MED)
 * between two words. MED(x, y) is the minimal sum of costs of edit 
 * operations used to transform x to y. Sample costs are given below:
 * 
 * cost (replace a letter) = 1
 * cost (delete a letter) = 0.9
 * cost (insert a letter) = 0.8
 * Example: x = "developer", y = "enveloped" --> cost = 2.7 
 * delete ‘d’:  "developer" --> "eveloper", cost = 0.9
 * insert ‘firstWordLength’:  "eveloper" --> "enveloper", cost = 0.8
 * replace ‘r’ --> ‘d’:  "enveloper" --> "enveloped", cost = 1
 * 
 */

namespace MinimumEditDistance
{
    using System;

    // For this task I used information and inspiration from:
    // http://www.stanford.edu/class/cs124/lec/med.pdf
    // http://www.dotnetperls.com/levenshtein
    // http://forums.academy.telerik.com/100822/%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-dynamic-programming-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0-minimum-edit-distance
    public static class MED
    {
        private const decimal DeleteCost = 0.9M;
        private const decimal InsertCost = 0.8M;
        private const decimal ReplaceCost = 1M;
        private static decimal[,] levenstainMatrix;

        public static void Main()
        {
            // Test the algorithm with some test words:
            decimal test;

            test = Compute(string.Empty, string.Empty);
            Console.WriteLine("Words:  -> ");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("developer", string.Empty);
            Console.WriteLine("Words: developer ->  ");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute(string.Empty, "developer");
            Console.WriteLine("Words:  -> developer");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("a", "b");
            Console.WriteLine("Words: a -> b");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("a", "A");
            Console.WriteLine("Words: a -> A");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("developer", "enveloped");
            Console.WriteLine("Words: developer -> enveloped");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("developer", "eveloper");
            Console.WriteLine("Words: developer -> eveloper");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("eveloper", "enveloper");
            Console.WriteLine("Words: eveloper -> enveloper");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
            Console.WriteLine();

            test = Compute("horse", "house");
            Console.WriteLine("Words:  -> ");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();

            test = Compute("horse", "house");
            Console.WriteLine("Words:  -> ");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();

            test = Compute("black", "white");
            Console.WriteLine("Words:  -> ");
            Console.WriteLine("Minimum Edit Distance - (MED) = {0}", test);
            PrintTableWithCosts();
        }

        /// <summary>
        /// Compute the distance between two strings.
        /// </summary>
        public static decimal Compute(string firstWord, string secondWord)
        {
            int firstWordLength = firstWord.Length;
            int secondWordLength = secondWord.Length;
            levenstainMatrix = new decimal[firstWordLength + 1, secondWordLength + 1];

            // Step 1
            if (firstWordLength == 0)
            {
                return secondWordLength;
            }

            if (secondWordLength == 0)
            {
                return firstWordLength;
            }

            // Step 2
            // By row fill the cost of deletions.
            for (int row = 0; row <= firstWordLength; row++)
            {
                levenstainMatrix[row, 0] = row * DeleteCost;
            }

            // By col fill the cost of insertions.
            for (int col = 0; col <= secondWordLength; col++)
            {
                levenstainMatrix[0, col] = col * InsertCost;
            }

            // Step 3 - Calculate cost operation and find min cost of them.
            for (int row = 1; row <= firstWordLength; row++)
            {
                // Step 4
                for (int col = 1; col <= secondWordLength; col++)
                {
                    // Step 5 - Calculate the cost for replacing. Return replace cost or 0 if equeal.
                    decimal costRepl = (secondWord[col - 1] == firstWord[row - 1]) ? 0 : ReplaceCost;

                    // Step 6 - Find the minimal cost operation from all-
                    decimal costDelete = levenstainMatrix[row - 1, col] + DeleteCost;
                    decimal costInsert = levenstainMatrix[row, col - 1] + InsertCost;
                    decimal costReplace = levenstainMatrix[row - 1, col - 1] + costRepl;

                    levenstainMatrix[row, col] = Math.Min(Math.Min(costDelete, costInsert), costReplace);
                }
            }

            // Step 7 - Return the result
            return levenstainMatrix[firstWordLength, secondWordLength];
        }

        public static void PrintTableWithCosts()
        {
            bool hasTwoWords = MissingWord();
            if (hasTwoWords)
            {
                Console.WriteLine("Costs table");
                for (int i = 0; i < levenstainMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < levenstainMatrix.GetLength(1); j++)
                    {
                        Console.Write("{0, 4} ", levenstainMatrix[i, j]);
                    }

                    Console.WriteLine();
                }
            }            
        }

        public static bool MissingWord()
        {
            bool hasTwoWords = true;
            bool missingFirstWord = levenstainMatrix.GetLength(0) == 1 && levenstainMatrix[0, 0] == 0;
            bool missingSecondWord = levenstainMatrix.GetLength(1) == 1 && levenstainMatrix[0, 0] == 0;

            if (missingFirstWord && missingSecondWord)
            {
                Console.WriteLine("No words! No table!");
                hasTwoWords = false;
            }
            else if (missingFirstWord)
            {
                Console.WriteLine("No table! Cost is the length of the second word!");
                hasTwoWords = false;
            }
            else if (missingSecondWord)
            {
                Console.WriteLine("No table! Cost is the length of the first word!");
                hasTwoWords = false;
            }

            return hasTwoWords;
        }
    }
}