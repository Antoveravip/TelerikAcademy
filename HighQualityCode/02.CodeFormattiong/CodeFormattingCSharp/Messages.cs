namespace CodeFormattingCSharp
{
    using System;
    using System.Text;

    public static class Messages
    {
        private static readonly StringBuilder Output = new StringBuilder();

        public static void EventAdded()
        {
            Output.Append("Event added" + Environment.NewLine);
        }

        public static void EventDeleted(int number)
        {
            if (number == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted" + Environment.NewLine, number);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found" + Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + Environment.NewLine);
            }
        }

        public static string OutputMessage
        {
            get
            {
                return Output.ToString();
            }
        }
    }
}