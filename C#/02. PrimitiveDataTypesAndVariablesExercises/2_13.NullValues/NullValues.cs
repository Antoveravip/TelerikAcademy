/* Lesson 2 - Primitive Data Types and Variables
 * Homework 13
 * Create a program that assigns null values to an integer and to double variables.
 * Try to print them on the console, try to add some values or the null literal to 
 * them and see the result.
 */

using System;

class NullValues
{
    static void Main()
    {
        Console.WriteLine(
            new string('-', 50) +
            "\nExample with Default null value:\n" +
            new string('-', 50));
        int defInt = 0;
        double defDoub = 0.0D;
        Console.WriteLine("\nThis is the integer with Default value: ({0}).\nThis is the real number with Default value: ({1}).\n", defInt, defDoub);
        Console.WriteLine(
            new string('-', 50) +
            "\nExample with NULL value:\n" +
            new string('-', 50));
        int? intNul = null;
        double? doubNul = null;
        Console.WriteLine("\nThis is the integer with Null value: ({0}).\nThis is the real number with Null value: ({1}).\n", intNul, doubNul);
        Console.WriteLine(
            new string('-', 50) +
            "\nExample with value 7:\n" +
            new string('-', 50));
        defInt = 7;
        defDoub = 7.0f;
        Console.WriteLine("\nThis is the integer with value 7: ({0}).\nThis is the real number with value 7: ({1}).\n", defInt, defDoub);
        Console.WriteLine(new string('-', 50));
    }
}