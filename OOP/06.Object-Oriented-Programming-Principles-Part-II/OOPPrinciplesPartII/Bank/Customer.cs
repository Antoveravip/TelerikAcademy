namespace Bank
{
    using System;

    public abstract class Customer
    {
        // --- FIELDS --- //
        private string id;
        private string name;
        private string lastName;
        private string address;
        private string phone;

        // --- PROPERTIES --- //
        public string ID
        {
            get { return id; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ID is mandatory data!");
                }
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name is mandatory data!");
                }
                name = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name is mandatory data!");
                }
                lastName = value;
            }
        }

        public string Address
        {
            get { return address; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address is mandatory data!");
                }
                address = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone is mandatory data!");
                }
                phone = value;
            }
        }

        // --- CONSTRUCTORS --- //
        protected Customer(string id, string name, string lastName, string address, string phone)
        {
            this.ID = id;
            this.Name = name;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
        }
    }
}