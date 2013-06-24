/* Lesson 4 - Methods
 * Homework 11
 * 
 * Write a method that adds two polynomials. 
 * Represent them as arrays of their coefficients
 * as in the example below:
 * x2 + 5 = 1x2 + 0x + 5 --> 501
 */

using System;

class AddsTwoPolynomials
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