/* Lesson 2 - Primitive Data Types and Variables
 * Homework 11
 * Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
 */

using System;

class ValuesExchange
{
    static void Main()
    {
        int firstNum = 5;
        int secNum = 10;
        Console.WriteLine("The first number is {0} - the second {1}", firstNum, secNum);
        int exchange;
        exchange = firstNum;
        firstNum = secNum;
        secNum = exchange;
        Console.WriteLine("Now the first number is {0} - and the second {1}", firstNum, secNum);
        //Another way
        firstNum = 5;
        secNum = 10;
        firstNum = firstNum + secNum;
        secNum = firstNum - secNum;
        firstNum = firstNum - secNum;
        Console.WriteLine("And now the first number is {0} - and the second {1}", firstNum, secNum);
    }
}