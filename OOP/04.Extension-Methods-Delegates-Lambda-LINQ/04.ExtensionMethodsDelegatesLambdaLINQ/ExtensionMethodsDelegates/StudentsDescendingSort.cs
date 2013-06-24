using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class StudentsDescendingSort
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

        //Homework 5 - Using the extension methods OrderBy() and ThenBy() with lambda 
        //expressions sort the students by first name and last name in descending order. 
        public static void LambdaDescendingSort(Students[] students)
        {
            var descendingSort =
                students.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);

            foreach (var student in descendingSort)
            {
                Console.WriteLine(student.ToString());
            }
        }
        //Homework 5 - Rewrite the same with LINQ.
        public static void LINQDescendingSort(Students[] students)
        {
            var sorted =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sorted)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}