namespace Bank
{
    using System;

    public class Individual : Customer
    {
        public Individual(string id, string name, string lastName, string address, string phone)
            : base(id, name, lastName, address, phone)
        {
        }
    }
}