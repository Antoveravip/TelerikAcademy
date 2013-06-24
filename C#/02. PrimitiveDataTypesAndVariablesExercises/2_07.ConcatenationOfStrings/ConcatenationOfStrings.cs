/* Lesson 2 - Primitive Data Types and Variables
 * Homework 7
 * Declare two string variables and assign them with “Hello” and “World”.
 * Declare an object variable and assign it with the concatenation 
 * of the first two variables (mind adding an interval).
 * Declare a third string variable and initialize it with the value of 
 * the object variable (you should perform type casting).
 */

using System;

class ConcatenationOfStrings
{
    static void Main()
    {
        string firstStr;
        firstStr = "Hello";
        string secStr;
        secStr = "World";
        object cont;
        cont = firstStr + " " + secStr;
        string thirdStr = (string)cont;
        Console.WriteLine(thirdStr);
    }
}