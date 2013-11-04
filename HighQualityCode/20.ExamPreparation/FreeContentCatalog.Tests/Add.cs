using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FreeContentCatalog.Tests
{
    [TestClass]
    public class Add
    {
        [TestMethod]
        public void AddSingleItem()
        {
            Catalog catalog = new Catalog();
            string[] testData = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            ContentItem item = new ContentItem(ContentItemType.Book, testData);
            catalog.Add(item);

            Assert.AreEqual(1, catalog.Count);
        }

        [TestMethod]
        public void AddAndFindItem()
        {
            Catalog catalog = new Catalog();
            string[] testData = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            ContentItem item = new ContentItem(ContentItemType.Book, testData);
            catalog.Add(item);
            var result = catalog.GetListContent("Intro C#", 1);

            Assert.AreEqual(result.Count(), 1);
            Assert.AreSame(result.First(), item);
        }

        [TestMethod]
        public void AddDuplicatedItem()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };
            string[] testData2 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            ContentItem item1 = new ContentItem(ContentItemType.Book, testData1);
            ContentItem item2 = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(item1);
            catalog.Add(item2);

            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void AddSameDuplicatedItem()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };
            string[] testData2 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            ContentItem item1 = new ContentItem(ContentItemType.Book, testData1);
            catalog.Add(item1);
            catalog.Add(item1);
            ContentItem item2 = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(item2);

            Assert.AreEqual(3, catalog.Count);
        }

        [TestMethod]
        public void AddMultipleItems()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };
            string[] testData2 = new string[] { "The Secret", "Drew Heriot, Sean Byrne & others (2006)", "832763834", "http://t.co/dNV4d" };

            ContentItem book = new ContentItem(ContentItemType.Book, testData1);
            catalog.Add(book);

            ContentItem movie = new ContentItem(ContentItemType.Movie, testData2);
            catalog.Add(movie);

            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void AddAllTypesMultipleAndSameItems()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "Firefox v.11.0", "Mozilla", "16148072", "http://www.mozilla.org" };
            string[] testData2 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };
            string[] testData3 = new string[] { "One", "Metallica", "8771120", "http://goo.gl/dIkth7gs" };
            string[] testData4 = new string[] { "The Secret", "Drew Heriot, Sean Byrne & others (2006)", "832763834", "http://t.co/dNV4d" };
            string[] testData5 = new string[] { "One", "James Wong (2001)", "969763002", "http://www.imdb.com/title/tt0267804/" };
            string[] testData6 = new string[] { "Intro Java", "S.Nakov", "127363892", "http://www.introprogramming/java.info" };

            ContentItem application1 = new ContentItem(ContentItemType.Application, testData1);
            catalog.Add(application1);

            ContentItem book1 = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(book1);

            ContentItem song1 = new ContentItem(ContentItemType.Song, testData3);
            catalog.Add(song1);

            ContentItem movie1 = new ContentItem(ContentItemType.Movie, testData4);
            catalog.Add(movie1);

            ContentItem movie2 = new ContentItem(ContentItemType.Movie, testData5);
            catalog.Add(movie2);

            ContentItem book2 = new ContentItem(ContentItemType.Book, testData6);
            catalog.Add(book2);

            catalog.Add(application1);
            catalog.Add(book1);
            catalog.Add(song1);
            catalog.Add(movie1);
            catalog.Add(movie2);
            catalog.Add(book2);

            Assert.AreEqual(12, catalog.Count);
        }

        [TestMethod]
        //[Timeout(700)]
        public void AddWith30kItems()
        {
            Catalog catalog = new Catalog();
            string[] testData = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            for (int i = 0; i < 30000; i++)
            {
                ContentItem item = new ContentItem(ContentItemType.Book, testData);
                catalog.Add(item);
            }

            Assert.AreEqual(30000, catalog.Count);
        }
    }
}
