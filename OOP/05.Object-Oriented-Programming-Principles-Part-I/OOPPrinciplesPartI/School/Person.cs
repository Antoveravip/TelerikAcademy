namespace School
{
    using System;

    public class Person
    {
        // --- FIELDS --- //
        private string firstName;
        private string lastName;
        private string comments;

        // --- PROPERTIES --- //
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
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
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name is mandatory!");
                }
                this.lastName = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Person(string firstName, string lastName)
            : this(firstName, lastName, null)
        {
        }

        public Person(string firstName, string lastName, string comments)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.comments = comments;
        }
    }
}