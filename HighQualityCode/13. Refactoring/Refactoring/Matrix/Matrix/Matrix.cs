namespace Matrix
{
    using System;

    public class Matrix
    {
        public static void Main()
        {
            /*
            // For manual input from console
            Console.WriteLine("Enter a positive number in range [1, 100]: ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int dimension = int.Parse(input);
            
            MatrixEngine matrix = new MatrixEngine(dimension);
            Console.WriteLine(matrix);
            */
            MatrixEngine matrix = new MatrixEngine(6);
            Console.WriteLine(matrix);
        }
    }
}