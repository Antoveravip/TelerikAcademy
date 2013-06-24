using System;
using System.Collections.Generic;
using System.Linq;

namespace Timer
{
    public class Students
    {
        // --- FIELDS --- //
        private string firstName;
        private string lastName;
        private sbyte? age;

        //--- PROPERTIES ---/
        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public sbyte? Age
        {
            get { return this.age; }
            set 
            {
                if (age < 0 || age > 98) //97-year-old Australian is the oldest student in the world
                {
                    throw new ArgumentOutOfRangeException("Not correct age!");
                }
                else
	            {
                    this.age = value;
	            }
            }
        }
        // --- CONSTRUCTORS --- //
        public Students(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Students(string firstName, string lastName, sbyte? age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (age < 0 || age > 98)
            {
                throw new ArgumentOutOfRangeException("Not correct age!");
            }
            else
	        {
                this.age = age;
	        }
        }
        // --- METHODS --- //
        public override string ToString()
        {
            return string.Format("First Name: " + this.FirstName + "; Last Name: " + this.LastName + ", Age: " + this.Age);
        }
    }
}