namespace Person
{
    using System;

    class PersonTest
    {
        static void Main()
        {
            //Creating test persons
            Person donev = new Person("Kamen Donev", 35);
            Person ivanova = new Person("Anna Ivanova");
            Person penchev = new Person("Plamen Penchev", 0);
            Person popova = new Person("Katia Popova", null);

            Console.WriteLine(donev);
            Console.WriteLine(ivanova);
            Console.WriteLine(penchev);
            Console.WriteLine(popova);
        }
    }
}