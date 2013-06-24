/* Lesson 2 - Primitive Data Types and Variables
 * Homework 5
 * Declare a character variable and assign it with the symbol that has Unicode code 72.
 * Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
 */

using System;

class DeclareCharVar
{
    static void Main()
    {
        char charValue;
        int value = 72;
        string hexValue = value.ToString("X");
        string stringValue = Char.ConvertFromUtf32(value); //convert the char from int value
        charValue = (char)value;
        Console.WriteLine("The assigned integer value is {0} ...", value);
        Console.WriteLine("Which is {0} in a hexadecmial format ...", hexValue);
        Console.WriteLine("Which represent the characters {0} or {1}", stringValue, charValue);
    }
}