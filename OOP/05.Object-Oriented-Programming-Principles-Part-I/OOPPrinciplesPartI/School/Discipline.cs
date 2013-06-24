using System;

namespace School
{
    public class Discipline
    {
        // --- FIELDS --- //
        private string title;
        private byte lectures;
        private byte exercises;
        private string comments;

        // --- PROPERTIES --- //
        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Discipline title must be correct inputed!");
                }
                this.title = value;
            }
        }

        public byte Lectures
        {
            get
            {
                return this.lectures;
            }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Lecture must have proper workload!");
                }
                this.lectures = value;
            }
        }

        public byte Exercises
        {
            get
            {
                return this.exercises;
            }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Exercises must have proper workload!");
                }
                this.exercises = value;
            } 
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Discipline(string title, byte lectures, byte exercises)
            : this(title, lectures, exercises, null)
        { 
        }

        public Discipline(string title, byte lectures, byte exercises, string comments)
        {
            this.title = title;
            this.lectures = lectures;
            this.exercises = exercises;
            this.comments = comments;
        }
    }
}