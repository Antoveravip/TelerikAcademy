namespace Humans
{
    using System;

    public class Student : Human
    {
        // --- FIELDS --- //
        private byte grade;

        // --- PROPERTIES --- //
        public byte Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0 || value >= 25)
                {
                    throw new ArgumentOutOfRangeException("The value for grade is not proper!");
                }
                this.grade = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }
    }
}