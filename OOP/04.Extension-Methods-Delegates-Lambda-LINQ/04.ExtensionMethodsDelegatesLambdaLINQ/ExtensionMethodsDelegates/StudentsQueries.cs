using System;
using System.Collections.Generic;
using System.Linq;

namespace Timer
{
    public class StudentsQueries
    {
        //Test Students array
        Students[] students = {
                new Students("Qsen", "Popov", 32),
                new Students("Alexandra", "Qsenova",21),
                new Students("Petar", "Asenov", 25),
                new Students("Georgi", "Bakalov", 18),
                new Students("Boika", "Vaseva", 21),
                new Students("Kamen", "Spasov", 18),
                new Students("Tania","Gerova", 20)};

        //Homework 3 - Write a method that from a given array of students finds all students
        //whose first name is before its last name alphabetically. Use LINQ query operators.
        public static void AlphabeticalFindStudent(Students[] students)
        {
            var alphabeticalFind =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (Students student in alphabeticalFind)
            {
                Console.WriteLine(student.ToString());
            }
        }
        //Homework 4 - Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        public static void FindStudentInAgeRange(Students[] students)
        {
            var studentInAgeRange =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in studentInAgeRange)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}