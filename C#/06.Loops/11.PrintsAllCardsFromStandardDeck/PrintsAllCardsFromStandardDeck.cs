/* Lesson 6 - Loops
 * Homework 11
 * Write a program that prints all possible cards from a standard deck
 * of 52 cards (without jokers). The cards should be printed with their
 * English names. Use nested for loops and switch-case.
 */

using System;

class PrintsAllCardsFromStandardDeck
{
    static void Main()
    {
        byte card, color, cardNumber = 1, colorNumber = 1;
        while (cardNumber != 5)
        {
            for (card = 2; card <= 14; card++)
            {
                for (color = colorNumber; color <= cardNumber; color++)
                {
                    switch (card)
                    {
                        case 2: { Console.Write("Two"); break; }
                        case 3: { Console.Write("Three"); break; }
                        case 4: { Console.Write("Four"); break; }
                        case 5: { Console.Write("Five"); break; }
                        case 6: { Console.Write("Six"); break; }
                        case 7: { Console.Write("Seven"); break; }
                        case 8: { Console.Write("Eight"); break; }
                        case 9: { Console.Write("Nine"); break; }
                        case 10: { Console.Write("Ten"); break; }
                        case 11: { Console.Write("Jack"); break; }
                        case 12: { Console.Write("Queen"); break; }
                        case 13: { Console.Write("King"); break; }
                        case 14: { Console.Write("Ace"); break; }
                        default: { Console.WriteLine("No such card!"); break; }
                    }
                    switch (color)
                    {
                        case 1: { Console.WriteLine(" of Clubs"); break; }
                        case 2: { Console.WriteLine(" of Diamonds"); break; }
                        case 3: { Console.WriteLine(" of Hearts"); break; }
                        case 4: { Console.WriteLine(" of Spades"); break; }
                        default: { Console.WriteLine("No such card!"); break; }
                    }
                }
            }
            Console.WriteLine();
            cardNumber++;
            colorNumber++;
        }
    }
}