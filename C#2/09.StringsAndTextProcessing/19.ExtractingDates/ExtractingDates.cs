/* Lesson 9 - Strings and Text Processing
 * Homework 19
 * 
 * Write a program that extracts from a given text all 
 * dates that match the format DD.MM.YYYY. Display them 
 * in the standard date format for Canada.
 */

using System;
using System.Globalization;

class ExtractingDates
{
    static void Main()
    {
        string inputData = @"03.02.2013 11:00 - Малкият Мук - София » Младежки театър - голяма зала.
                             На 06.02.2013 и 07.02.2013 година в Интер Експо Център София ще се проведе петото издание на българския семинар за организатори на събития и техните партньори – Eventex Seminar.
                             Изложба - Цариградски импресии - 01.02.2013 11:00 до 15.02.2013 18:00.";
        string[] words = inputData.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            try
            {
                string wordNoDot = word;
                if (word[word.Length - 1] == '.')
                {
                    wordNoDot = word.Substring(0, word.Length - 1);
                }
                DateTime date = DateTime.ParseExact(word, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string dateCanada = date.ToString("dd/MM/yy", CultureInfo.InvariantCulture);
                Console.WriteLine(dateCanada);
            }
            catch (Exception)
            {
            }
        }
    }
}