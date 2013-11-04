using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FreeContentCatalog.Tests
{
    [TestClass]
    public class GetListContent
    { 
        [TestMethod]
        public void GetListContentSingleItem()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "Firefox v.11.0", "Mozilla", "16148072", "http://www.mozilla.org" };
            string[] testData2 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            ContentItem application = new ContentItem(ContentItemType.Application, testData1);
            catalog.Add(application);

            ContentItem book = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(book);

            var result = catalog.GetListContent("Intro C#", 5);

            Assert.AreEqual(result.Count(), 1);
            Assert.AreSame(result.First(), book);
        }

        [TestMethod]
        public void GetListContentMissingItem()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "Firefox v.11.0", "Mozilla", "16148072", "http://www.mozilla.org" };
            string[] testData2 = new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" };

            ContentItem application = new ContentItem(ContentItemType.Application, testData1);
            catalog.Add(application);

            ContentItem book = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(book);

            var result = catalog.GetListContent("Unknown data", 5);

            Assert.AreEqual(result.Count(), 0);
        }

        [TestMethod]
        public void GetListContentMatchingItems()
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

            var result = catalog.GetListContent("One", 10);

            Assert.AreEqual(result.Count(), 2);
        }

        [TestMethod]
        public void GetListContentGetFirstOnlyFromMatchingItems()
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

            var result = catalog.GetListContent("One", 1);

            Assert.AreEqual(result.Count(), 1);
        }

        [TestMethod]
        public void GetListContentOrderedFromMatchingNameDifferentItems()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "One", "A.Molina", "4316148072", "http://www.asdmozilla.org" };
            string[] testData2 = new string[] { "Java part1", "S.Nakov", "12763892", "http://www.intsfroprogramming.info" };
            string[] testData3 = new string[] { "One", "Metallica", "8771120", "http://goo.gl/dIkth7gs" };
            string[] testData4 = new string[] { "The Secret", "Drew Heriot, Sean Byrne & others (2006)", "832763834", "http://t.co/dNV4d" };
            string[] testData5 = new string[] { "One", "James Wong (2001)", "969763002", "http://www.imdb.com/title/tt0267804/" };
            string[] testData6 = new string[] { "The big one", "S.Antonov", "22127363892", "http://www.intfsfsroprogramming/java.info" };

            ContentItem book1 = new ContentItem(ContentItemType.Book, testData1);
            catalog.Add(book1);

            ContentItem book2 = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(book2);

            ContentItem song1 = new ContentItem(ContentItemType.Song, testData3);
            catalog.Add(song1);

            ContentItem movie1 = new ContentItem(ContentItemType.Movie, testData4);
            catalog.Add(movie1);

            ContentItem movie2 = new ContentItem(ContentItemType.Movie, testData5);
            catalog.Add(movie2);

            ContentItem application = new ContentItem(ContentItemType.Application, testData6);
            catalog.Add(application);

            var result = catalog.GetListContent("One", 10);

            Assert.AreEqual(result.Count(), 3);

            string[] expected = 
            {
                "Book: One; A.Molina; 4316148072; http://www.asdmozilla.org",
                "Movie: One; James Wong (2001); 969763002; http://www.imdb.com/title/tt0267804/",
                "Song: One; Metallica; 8771120; http://goo.gl/dIkth7gs"

            };
            string[] actual = new string[] 
            {
                result.First().ToString(),
                result.Skip(1).First().ToString(),
                result.Skip(2).First().ToString()
            };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetListContentOrderedFromMatchingNameOfThreeSameItems()
        {
            Catalog catalog = new Catalog();
            string[] testData1 = new string[] { "One", "A.Molina", "4316148072", "http://www.asdmozilla.org" };
            string[] testData2 = new string[] { "One", "S.Nakov", "12763892", "http://www.intsfroprogramming.info" };
            string[] testData3 = new string[] { "One", "Metallica", "8771120", "http://goo.gl/dIkth7gs" };
            string[] testData4 = new string[] { "The Secret", "Drew Heriot, Sean Byrne & others (2006)", "832763834", "http://t.co/dNV4d" };
            string[] testData5 = new string[] { "One", "James Wong (2001)", "969763002", "http://www.imdb.com/title/tt0267804/" };
            string[] testData6 = new string[] { "One", "S.Antonov", "22127363892", "http://www.intfsfsroprogramming/java.info" };

            ContentItem book1 = new ContentItem(ContentItemType.Book, testData1);
            catalog.Add(book1);

            ContentItem book2 = new ContentItem(ContentItemType.Book, testData2);
            catalog.Add(book2);

            ContentItem song1 = new ContentItem(ContentItemType.Song, testData3);
            catalog.Add(song1);

            ContentItem movie1 = new ContentItem(ContentItemType.Movie, testData4);
            catalog.Add(movie1);

            ContentItem movie2 = new ContentItem(ContentItemType.Movie, testData5);
            catalog.Add(movie2);

            ContentItem book3 = new ContentItem(ContentItemType.Book, testData6);
            catalog.Add(book3);

            var result = catalog.GetListContent("One", 10);

            Assert.AreEqual(result.Count(), 5);

            string[] expected = 
            {
                "Book: One; A.Molina; 4316148072; http://www.asdmozilla.org",
                "Book: One; S.Antonov; 22127363892; http://www.intfsfsroprogramming/java.info",
                "Book: One; S.Nakov; 12763892; http://www.intsfroprogramming.info",
                "Movie: One; James Wong (2001); 969763002; http://www.imdb.com/title/tt0267804/",
                "Song: One; Metallica; 8771120; http://goo.gl/dIkth7gs"

            };
            string[] actual = new string[] 
            {
                result.First().ToString(),
                result.Skip(1).First().ToString(),
                result.Skip(2).First().ToString(),
                result.Skip(3).First().ToString(),
                result.Skip(4).First().ToString()
            };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Timeout(10000)]
        public void TestSearchPerformance()
        {
            int addsCount = 10000;
            int searchCount = 50000;

            // Prepare the input commands
            StringBuilder input = new StringBuilder();
            for (int i = 0; i < addsCount; i++)
            {
                input.AppendLine("Add application: app; a; 12345; http://oldurl");
            }
            for (int i = 0; i < searchCount; i++)
            {
                input.AppendLine("Find: app; 100");
            }
            input.AppendLine("End");

            // Prepare the expected result 
            StringBuilder expectedOutput = new StringBuilder();
            for (int i = 0; i < addsCount; i++)
            {
                expectedOutput.AppendLine("Application added");
            }
            for (int i = 0; i < searchCount * 100; i++)
            {
                expectedOutput.AppendLine("Application: app; a; 12345; http://oldurl");
            }

            // Redirect the console input / output and invoke the Main() method
            Console.SetIn(new StringReader(input.ToString()));
            StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            CatalogEngine.Main();

            // Assert that the program execution result is correct
            string expected = expectedOutput.ToString();
            string actual = consoleOutput.ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}