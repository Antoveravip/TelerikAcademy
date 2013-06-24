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

    public class Article : IComparable<Article>
    {
        public Article(int barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vedndor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int Barcode { get; set; }

        public string Vedndor { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article otherArticle)
        {
            return this.Price.CompareTo(otherArticle.Price);
        }
    }
}
