/* Lesson 4 - Methods
 * Homework 1
 * 
 * Write a method that asks the user for his name and prints
 * “Hello, <name>” (for example, “Hello, Peter!”).
 * Write a program to test this method.
 */

using System;

class PrintName
{
    static void PrintFirstName()
    {
        Console.Write("Please enter your first name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name); 
    }

    static void Main()
    {
        PrintFirstName();
    }
}