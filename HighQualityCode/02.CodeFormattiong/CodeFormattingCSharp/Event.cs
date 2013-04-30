namespace CodeFormattingCSharp
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            private set
            {
                this.location = value;
            }
        }

        public int CompareTo(object otherObject)
        {
            Event otherEvent = otherObject as Event;

            if (this == null)
            {
                if (otherEvent == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else if (otherEvent == null)
            {
                return -1;
            }
            else
            {
                int compareByDate = this.Date.CompareTo(otherEvent.Date);
                int compareByTitle = this.Title.CompareTo(otherEvent.Title);
                int compareByLocation = this.Location.CompareTo(otherEvent.Location);

                if (compareByDate == 0)
                {
                    if (compareByTitle == 0)
                    {
                        return compareByLocation;
                    }
                    else
                    {
                        return compareByTitle;
                    }
                }
                else
                {
                    return compareByDate;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder eventData = new StringBuilder();
            eventData.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            eventData.Append(" | " + this.Title);

            if (this.Location != null && this.Location != string.Empty)
            {
                eventData.Append(" | " + this.Location);
            }

            return eventData.ToString();
        }
    }
}