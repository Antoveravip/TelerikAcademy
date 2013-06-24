/* Lesson 2 - Primitive Data Types and Variables
 * Homework 6
 * Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
 */

using System;

class GenderType
{
    static void Main()
    {
        bool isFemale;
        isFemale = false;
        Console.WriteLine("Are you female?");
        Console.WriteLine("{0}!", isFemale);
    }
}