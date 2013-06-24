/* Lesson 7 - Data Structures Efficiency
 * Homework 3
 * 
 * Implement a class BiDictionary<K1,K2,T> that allows adding triples 
 * {key1, key2, value} and fast search by key1, key2 or by both key1 
 * and key2. Note: multiple values can be stored for given key.
 */

namespace BiDictionaryImplementation
{
    using System;

    public class CheckImplementation
    {
        public static void Main()
        {
            BiDictionary<string, string, string> contacts = new BiDictionary<string, string, string>();
            contacts.Add("Sofia", "coleague", "Kamen Donev");
            contacts.Add("Sofia", "friend", "Kamen Donev");
            contacts.Add("Sofia", "friend", "Ani Topalova");
            contacts.Add("Plovdiv", "father", "Peter Topalov");
            contacts.Add("Plovdiv", "girlfriend", "Silviq Petrova");
            contacts.Add("Plovdiv", "friend", "Silviq Petrova");
            contacts.Add("Varna", "coleague", "Ivan Stoikov");
            contacts.Add("Plovdiv", "coleague", "Petar Popov");
            contacts.Add("Varna", "girlfriend", "Iliana Velinova");
            contacts.Add("Trojan", "girlfriend", "Nadq Pavlova");

            var peopleInSofia = contacts.FindByFistKey("Sofia");
            Console.WriteLine("People I know in Sofia:");
            foreach (var item in peopleInSofia)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var myGirls = contacts.FindBySecondKey("girlfriend");
            Console.WriteLine("My beloved girls all over the country:");
            foreach (var item in myGirls)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var friendsInPlovdiv = contacts.FindByBothKeys("Plovdiv", "friend");
            Console.WriteLine("My friends in Plovdiv");
            foreach (var item in friendsInPlovdiv)
            {
                Console.WriteLine(item);
            }
        }
    }
}