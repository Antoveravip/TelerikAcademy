/* Lesson 7 - Data Structures Efficiency
 * Homework 1
 * 
 * A text file students.txt holds information about students and their courses 
 * in the following format:
 * 
 * Kiril  | Ivanov   | C#
 * Stefka | Nikolova | SQL
 * Stela  | Mineva   | Java
 * Milena | Petrova  | C#
 * Ivan   | Grigorov | C#
 * Ivan   | Kolev    | SQL
 * 
 * Using SortedDictionary<K,T> print the courses in alphabetical order and for 
 * each of them prints the students ordered by family and then by name:
 * 
 * C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
 * Java: Stela Mineva
 * SQL: Ivan Kolev, Stefka Nikolova
 */

namespace StudentsData
{
    using System;

    public class Student : IComparable<Student>
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { }
        }

        public int CompareTo(Student otherStudent)
        {
            int result = this.lastName.CompareTo(otherStudent.lastName);
            if (result == 0)
            {
                result = this.firstName.CompareTo(otherStudent.firstName);
            }

            return result;
        }
    }
}