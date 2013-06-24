/* Lesson 2 - Primitive Data Types and Variables
 * Homework 2
 * Which of the following values can be assigned to a variable
 * of type float and which to a variable of type double: 
 * 34.567839023, 12.345, 8923.1234857, 3456.091?
 */

using System;

class AssigningOfValues
{
    static void Main()
    {
        //Assigning the values to a variable of type float and double
        double firstValue = 34.567839023;
        float secondValue = 12.345f;
        double thirdValue = 8923.1234857;
        float fourthValue = 3456.091f;
        //Checking for losses of data - variables of type float
        Console.WriteLine("The {0} and {1} values must be assigned to float data type", secondValue, fourthValue);
        Console.WriteLine("This check showing that there is no losses of data\n");
        float sumOfFloatVariables = secondValue + fourthValue;
        float sumOfFloatValues = 3468.436f;
        bool equalFloat = (sumOfFloatVariables == sumOfFloatValues);
        Console.WriteLine("{0}+{1}={2}\nThe float sum={3}\nFloat equal = {4}\n", secondValue, fourthValue, sumOfFloatVariables, sumOfFloatValues, equalFloat);
        //Checking for losses of data - variables of type double
        Console.WriteLine("The {0} and {1} values must be assigned to double data type", firstValue, thirdValue);
        Console.WriteLine("This check showing that there is no losses of data\n");
        double sumOfDoubleVariables = firstValue + thirdValue;
        double sumOfDoubleValues = 8957.691324723;
        bool equalDouble = (sumOfDoubleVariables == sumOfDoubleValues);
        Console.WriteLine("{0}+{1}={2}\nThe double sum={3}\nDouble equal = {4}\n", firstValue, thirdValue, sumOfDoubleVariables, sumOfDoubleValues, equalDouble);
    }
}