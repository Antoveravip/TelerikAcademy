/* Lesson 9 - Strings and Text Processing
 * Homework 3
 * 
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

using System;

class ChecksExpressionBrackets
{
    static void Main()
    {
        //Test expression
        string expression = "(2-1)*(2*(42-2)/4)(";
        /*
        Console.Write("Write one expression: ");
        string expression = Console.ReadLine();
        */
        CheckIsPutCorrectBrackets(expression);
    }

    static void CheckIsPutCorrectBrackets(string expression)
    {
        char[] exprChars = expression.ToCharArray();
        int brackets = 0;

        for (int i = 0; i < exprChars.Length; i++)
        {
            if (exprChars[i] == '(')
            {
                brackets++;
            }
            else if (exprChars[i] == ')')
            {
                brackets--;
            }
            if (brackets < 0)
            {
                break;
            }
        }
        if (brackets == 0)
        {
            Console.WriteLine("The brackets in this expresion is correct!");
        }
        else
        {
            Console.WriteLine("The brackets in this expresion is NOT put correctly!");
        }
    }
}