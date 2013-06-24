/* Lesson 5 - Conditional Statements
 * Homework 8
 * Write a program that, depending on the user's choice inputs int,
 * double or string variable. If the variable is integer or double,
 * increases it with 1. If the variable is string, appends "*" at its
 * end. The program must show the value of that variable as a console
 * output. Use switch statement.
 */

using System;

class InputDifferentVariables
{
    static byte choise;
    static int intVar;
    static double doubleVar;
    static string stringVar, inputData;

    static void InputTypeCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            check = byte.TryParse(inputData, out choise);
            if (check == false || choise < 1 || choise > 3)
            {
                check = false;
                Console.Write("Not correct type! Please enter again:");
            }
            else
            {
                check = true;
                choise = byte.Parse(inputData);
            }
        }
    }

    static void InputCheck()
    {
        bool check = false;
        while (check != true)
        {
            inputData = Console.ReadLine();
            switch (choise)
            {
                case 1: { check = int.TryParse(inputData, out intVar); break; }
                case 2: { check = double.TryParse(inputData, out doubleVar); break; }
                case 3: { check = true; break; }
                default: { check = false; break; }
            }
            if (check == false)
            {
                Console.Write("Not correct value! Please enter again:");
            }
            else
            {
                check = true;
                switch (choise)
                {
                    case 1:
                        {
                            intVar = int.Parse(inputData);
                            intVar = intVar + 1;
                            Console.WriteLine("The entered variable is modified to {0}", intVar);
                            break;
                        }
                    case 2:
                        {
                            doubleVar = double.Parse(inputData);
                            doubleVar = doubleVar + 1;
                            Console.WriteLine("The entered variable is modified to {0}", doubleVar);
                            break;
                        }
                    case 3:
                        {
                            stringVar = inputData;
                            stringVar = stringVar + "*";
                            Console.WriteLine("The entered variable is modified to {0}", stringVar);
                            break;
                        }
                    default: { check = false; break; }
                }
            }
        }
    }

    static void Main()
    {
        //One way is using loop for!
        Console.Write("Choose what type variable you want to input?\n1.Int\n2.Double\n3.String\n");
        Console.Write("Choose 1,2 or 3:");
        InputTypeCheck();
        Console.Write("Enter a value for the selected variable:");
        InputCheck();
    }
}