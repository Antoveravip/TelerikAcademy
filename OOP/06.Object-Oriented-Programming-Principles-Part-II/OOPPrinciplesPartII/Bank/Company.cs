namespace Bank
{
    using System;

    public class Company : Customer
    {
        public Company(string id, string name, string address, string phone)
            : base(id, name, " ", address, phone)
        {
        }
    }
}