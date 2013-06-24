/* Lesson 6 - Advanced Data Structures
 * Homework 2
 * 
 * Write a program to read a large collection of products (name + price)
 * and efficiently find the first 20 products in the price range [a…b].
 * Test for 500 000 products and 10 000 price searches.
 * Hint: you may use OrderedBag<T> and sub-ranges.
 */

namespace ProductsCollection
{
    using System;

    public class Product : IComparable<Product>
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }      

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Name must be not null or empty.");
                }

                this.name = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be more than zero.");
                }

                this.price = value;
            }
        }

        public int CompareTo(Product otherProduct)
        {
            if (this.price < otherProduct.Price)
            {
                return 1;
            }

            if (this.price > otherProduct.price)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            string data = string.Format("{0}: {1}", this.name, this.price);
            return data;
        }
    }
}