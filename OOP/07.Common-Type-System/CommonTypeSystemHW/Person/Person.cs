/* 07.Common-Type-System
 * 
 * Homework task 4:
 * 
 * Create a class Person with two fields – name and age. Age can be left unspecified 
 * (may contain null value. Override ToString() to display the information of a person 
 * and if age is not specified – to say so. Write a program to test this functionality. 
 * 
 */

namespace Person
{
    using System;

    public class Person
    {
        // --- FIELDS --- //
        private string name;
        private byte? age;

        // --- PROPERTIES --- //
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Missing name!");
                }
                this.name = value;
            }
        }

        public byte? Age
        {
            get { return this.age; }
            set
            {
                if (age < 0 || age > 127)
                {
                    throw new ArgumentOutOfRangeException("Invalid age. It should be in the range between 0 and 126.");
                }
                this.age = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        // --- METHODS --- //
        public override string ToString()
        {
            return String.Format("Name: {0}, Age:{1}", this.Name, this.Age != null ? this.Age.ToString() : "<not specified>");
        }
    }
}