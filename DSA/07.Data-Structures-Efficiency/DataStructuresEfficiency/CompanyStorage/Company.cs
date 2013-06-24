/* Lesson 7 - Data Structures Efficiency
 * Homework 2
 * 
 * A large trade company has millions of articles, each described by barcode, 
 * vendor, title and price. Implement a data structure to store them that allows
 * fast retrieval of all articles in given price range [x…y]. 
 * Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET. 
 */

namespace CompanyStorage
{
    using System;
    using Wintellect.PowerCollections;

    public class Company
    {
        public static void Main()
        {
            Article[] articles = 
            { 
                new Article(22161158, "Record", "Shoes", 40.00M),
                new Article(86152218, "Monbat", "Akumulators", 109.00M),
                new Article(13221801, "Ideal Standart", "Toilet", 69.00M),
                new Article(22168004, "ET Dani", "Honey", 1.50M),
                new Article(88157521, "Renault", "Brakes", 106.50M),
                new Article(87522382, "Pampers", "Pampers", 11.99M),
                new Article(99742154, "Always", "Tampons", 4.99M),
                new Article(26457821, "Nestle", "KitKat", 12.80M)
            };

            OrderedMultiDictionary<decimal, Article> catalog = new OrderedMultiDictionary<decimal, Article>(true);

            foreach (var article in articles)
            {
                catalog.Add(article.Price, article);
            }

            var pricesRange = catalog.FindAll(x => x.Key >= 1 && x.Key <= 30);
            foreach (var item in pricesRange)
            {
                string items = string.Empty;
                foreach (var article in item.Value)
                {
                    items += article.Title + " - " + article.Vedndor + " - " + article.Barcode + ";\n";
                }

                Console.WriteLine("Price: {0} - articles: {1}", item.Key, items);
            }
        }
    }
}