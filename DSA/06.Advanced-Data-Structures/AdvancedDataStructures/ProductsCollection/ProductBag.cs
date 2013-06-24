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
    using System.Collections.Generic;
    using System.Text;
    using Wintellect.PowerCollections;

    public static class ProductBag
    {
        public static void AddProducts(OrderedBag<Product> products, int countOfNewProducts)
        {
            for (int item = 1; item < countOfNewProducts; item++)
            {
                products.Add(new Product(item.ToString(), item));
            }
        }

        public static string GetProducts(List<Product> allProducts)
        {
            StringBuilder products = new StringBuilder();
            foreach (var product in allProducts)
            {
                products.AppendFormat("{0}: {1}\n", product.Name, product.Price);
            }

            products.AppendLine();

            return products.ToString();
        }

        public static List<Product> FindFirstNProducts(OrderedBag<Product> allProducts, int numberOfProducts, int lowPrice, int highPrice)
        {
            var firstNProducts = allProducts.Range(new Product("searchItem", highPrice), true, new Product("searchItem", lowPrice), true);

            List<Product> products = new List<Product>();

            if (firstNProducts.Count == 0)
            {
                return products;
            }

            for (int item = 0; item < numberOfProducts && item < firstNProducts.Count; item++)
            {
                products.Add(firstNProducts[item]);
            }

            return products;
        }
    }
}