/* Lesson 4 - Methods
 * Homework 12
 * 
 * Extend the program to support also subtraction
 * and multiplication of polynomials.
 */

using System;

class MoreOperationsWithPolynomials
{
    static void Main()
    {
        decimal[] firstPolynomial = { 7, -5 };
        Console.Write("First polynomial: ");
        PrintPolynomials(firstPolynomial);

        decimal[] secondPolynomial = { 12, -4, 8 };
        Console.Write("Second polynomial: ");
        PrintPolynomials(secondPolynomial);

        int maxLenght = 0;
        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            maxLenght = firstPolynomial.Length;
        }
        else
        {
            maxLenght = secondPolynomial.Length;
        }

        decimal[] result = new decimal[maxLenght];
        Console.WriteLine();

        SumPolynomials(firstPolynomial, secondPolynomial, result);

        Console.Write("Sum: ");
        PrintPolynomials(result);

        SubstractionOfPolynomials(firstPolynomial, secondPolynomial, result);

        Console.Write("Substraction: ");
        PrintPolynomials(result);

        decimal[] multiply = new decimal[firstPolynomial.Length + secondPolynomial.Length];
        MultiplyPolynomials(firstPolynomial, secondPolynomial, multiply);

        Console.Write("Multiplication: ");
        PrintPolynomials(multiply);
    }

    static void SumPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] sum)
    {
        int minLenght = 0;
        int smallerPolynomial = 0;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLenght = secondPolynomial.Length;
            smallerPolynomial = 2;
        }
        else
        {
            minLenght = firstPolynomial.Length;
            smallerPolynomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            sum[i] = firstPolynomial[i] + secondPolynomial[i];
        }

        for (int i = minLenght; i < sum.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                sum[i] = secondPolynomial[i];
            }
            else
            {
                sum[i] = firstPolynomial[i];
            }
        }
    }

    static void SubstractionOfPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynomial = 0;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLenght = secondPolynomial.Length;
            smallerPolynomial = 2;
        }
        else
        {
            minLenght = firstPolynomial.Length;
            smallerPolynomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynomial[i] - secondPolynomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                result[i] = secondPolynomial[i];
            }
            else
            {
                result[i] = firstPolynomial[i];
            }
        }
    }

    static void MultiplyPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolynomial[i] * secondPolynomial[j]);
            }
        }
    }

    static void PrintPolynomials(decimal[] Polynomial)
    {
        for (int i = Polynomial.Length - 1; i >= 0; i--)
        {
            if (Polynomial[i] != 0 && i != 0)
            {
                if (Polynomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, Polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, Polynomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", Polynomial[i]);
            }
        }

        Console.WriteLine();
    }
}