namespace Humans
{
    using System;

    public abstract class Human
    {
        // --- FIELDS --- //
        private string firstName;
        private string lastName;

        // --- PROPERTIES --- //
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name is mandatory!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name is mandatory!");
                }
                this.lastName = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}