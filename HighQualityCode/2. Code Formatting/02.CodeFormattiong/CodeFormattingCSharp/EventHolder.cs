namespace CodeFormattingCSharp
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private readonly MultiDictionary<string, Event> dictionaryByTitle = new MultiDictionary<string, Event>(true);
        private readonly OrderedBag<Event> orderedByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);

            this.dictionaryByTitle.Add(title.ToLower(), newEvent);
            this.orderedByDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.dictionaryByTitle[title])
            {
                removed++;
                this.orderedByDate.Remove(eventToRemove);
            }

            this.dictionaryByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.orderedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int displayed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (displayed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                displayed++;
            }

            if (displayed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}