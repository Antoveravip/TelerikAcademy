namespace School
{
    using System;

    public class Student :Person
    {
        // --- FIELDS --- //
        private uint studentID;

        // --- PROPERTIES --- //
        public uint StudentID
        {
            get
            {
                return this.studentID;
            }
            private set
            {
                if (studentID == 0)
                {
                    throw new ArgumentNullException("Student ID can not be zero!");
                }
                this.studentID = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Student(string firstName, string lastName, uint studentID)
            :this(firstName, lastName, null, studentID)
        { 
        }

        public Student(string firstName, string lastName, string comments, uint studentID)
                :base(firstName, lastName, comments)
        {
            this.studentID = studentID;
        }
    }
}