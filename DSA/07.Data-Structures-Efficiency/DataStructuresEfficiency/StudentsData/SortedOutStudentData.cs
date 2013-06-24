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
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Wintellect.PowerCollections;

    public static class SortedOutStudentData
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\students.txt");
            SortedDictionary<string, OrderedBag<Student>> courses = new SortedDictionary<string, OrderedBag<Student>>();
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] info = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    if (courses.ContainsKey(info[2]))
                    {
                        courses[info[2]].Add(new Student(info[0], info[1]));
                    }
                    else
                    {
                        courses[info[2]] = new OrderedBag<Student> { new Student(info[0], info[1]) };
                    }
                }

                foreach (var item in courses.OrderBy(x => x.Key))
                {
                    var students = item.Value;
                    Console.Write("{0}: ", item.Key);
                    foreach (var student in students)
                    {
                        Console.Write(student.FirstName + " " + student.LastName + ", ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}