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
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    using Wintellect.PowerCollections;

    public class IOProducts
    {
        public static void Main()
        {
            StringBuilder allProducts = new StringBuilder();
            Stopwatch checkTime = new Stopwatch();
            OrderedBag<Product> products = new OrderedBag<Product>();
            int ranges = 10000;

            checkTime.Start();
            ProductBag.AddProducts(products, 500001);

            checkTime.Stop();
            Console.WriteLine("All 500 000 products was added about: {0}", checkTime.Elapsed);
            checkTime.Reset();

            for (int i = 0; i < ranges; i++)
            {
                checkTime.Start();
                int lowPrice = 100000;
                int highPrice = 100000 + (i * 2);
                List<Product> found = ProductBag.FindFirstNProducts(products, 20, lowPrice, highPrice);
                
                checkTime.Stop();
                allProducts.Append(ProductBag.GetProducts(found));
            }

            Console.WriteLine("Searching products is done in: {0}", checkTime.Elapsed);
        }
    }
}