using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr", "The array is not initialized!");
        }

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("startIndex", "startIndex can't be less than zero.");
        }

        if (startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("startIndex", "startIndex can't be greater than the array's length!");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "count cannot be less than zero.");
        }

        if (startIndex > arr.Length - count)
        {
            throw new ArgumentOutOfRangeException("startIndex", "startIndex and count must be in range of the array.");
        }

        List<T> result = new List<T>();

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentNullException("str", "String value can't be null or empty.");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "count value can't be less than zero.");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count", "count can't be greater than the array's length!");
        }

        StringBuilder result = new StringBuilder();

        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        // A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself. 
        if (number < 2)
        {
            throw new ArgumentOutOfRangeException("number", "Number value must be greater than 1!");
        }

        bool isPrime = true;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
            }
        }

        return isPrime;
    }

    static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            // Throw exeption!
            //Console.WriteLine(ExtractEnding("Hi", 100));

            bool isPrimeNumber = CheckPrime(23);
            if (isPrimeNumber)
            {
                Console.WriteLine("23 is prime.");
            }
            else
            {
                Console.WriteLine("23 is not prime");
            }

            isPrimeNumber = CheckPrime(33);

            if (isPrimeNumber)
            {
                Console.WriteLine("33 is prime.");
            }
            else
            {
                Console.WriteLine("33 is not prime");
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        catch (ArgumentOutOfRangeException aoorex)
        {
            Console.WriteLine(aoorex.Message);
        }
        catch (ArgumentNullException anex)
        {
            Console.WriteLine(anex.Message);
        }
        catch (ArgumentException aex)
        {
            Console.WriteLine(aex.Message);
        }
    }
}