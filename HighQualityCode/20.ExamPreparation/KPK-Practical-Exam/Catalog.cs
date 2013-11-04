using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace FreeContentCatalog
{
    public class Catalog : ICatalog
    {
        private MultiDictionary<string, IContentItem> url;
        private OrderedMultiDictionary<string, IContentItem> title;

        public Catalog()
        {
            bool allowDuplicateValues = true;
            this.title = new OrderedMultiDictionary<string, IContentItem>(allowDuplicateValues);
            this.url = new MultiDictionary<string, IContentItem>(allowDuplicateValues);
        }

        public void Add(IContentItem content)
        {
            this.title.Add(content.Title, content);
            this.url.Add(content.URL, content);
        }

        public IEnumerable<IContentItem> GetListContent(string title, int numberOfContentElementsToList)
        {
            IEnumerable<IContentItem> contentToList = from c in this.title[title] select c;

            return contentToList.Take(numberOfContentElementsToList);
        }

        public int UpdateContent(string old, string newUrl)
        {
            int theElements = 0;

            List<IContentItem> contentToList = this.url[old].ToList();


            foreach (ContentItem content in contentToList)
            {
                this.title.Remove(content.Title, content);
                theElements++; //increase updatedElements
            }
            this.url.Remove(old);

            foreach (IContentItem content in contentToList)
            {
                content.URL = newUrl;
            }

            //again
            foreach (IContentItem content in contentToList)
            {
                this.title.Add(content.Title, content);
                this.url.Add(content.URL, content);
            }

            return theElements;
        }

        public int Count
        {
            get
            {
                return this.title.KeyValuePairs.Count;
            }
        }
    }
}