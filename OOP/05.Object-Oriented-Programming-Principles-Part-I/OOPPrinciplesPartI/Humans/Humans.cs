using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Humans
    {
        static void Main()
        {
            //Initializing a list of 10 students and sort them by grade in ascending order
            List<Student> students = new List<Student>();

            students.Add(new Student("Doncho", "Ivanov", 8));
            students.Add(new Student("Petar", "Popov", 11));
            students.Add(new Student("Kamen", "Donev", 12));
            students.Add(new Student("Kalina", "Kamenova", 10));
            students.Add(new Student("Nikolaj", "Spasov", 9));
            students.Add(new Student("Milena", "Hristova", 10));
            students.Add(new Student("Ana", "Pencheva", 12));
            students.Add(new Student("Petia", "Stanoeva", 11));
            students.Add(new Student("Hristo", "Shopov", 7));
            students.Add(new Student("Iva", "Nikolova", 8));

            //LINQ sort
            var sortedStudetns =
                from student in students
                orderby student.Grade
                select new Student(student.FirstName, student.LastName, student.Grade);

            //OrderBy() with lambda sort
            List<Student> orderedStudetns = new List<Student>(students.OrderBy(x => x.Grade));

            Console.WriteLine("Students:");
            foreach (var student in sortedStudetns)
            {
                Console.WriteLine("{0} {1}, Grade: {2}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine();

            //Initializing a list of 10 workers and sort them by money per hour in descending order. 
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Kamen", "Petrov", 8, 250),
                new Worker("Nikolai", "Kostov", 8, 300),
                new Worker("Neli", "Dimitrova", 4, 150),
                new Worker("Petia", "Peneva", 12, 400),
                new Worker("Kremena", "Ivanova", 12, 450),
                new Worker("Plamen", "Obretenov", 6, 200),
                new Worker("Kamelia", "Georgieva", 8, 280),
                new Worker("Boiko", "Penev", 12, 500),
                new Worker("Petar", "Borisov", 10, 450),
                new Worker("Kaloqn", "Shopov", 12, 380)
            };

            //LINQ sort
            var sortedWorkers =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            //OrderBy() with lambda sort
            var orderedWorkers = new List<Worker>(workers.OrderByDescending(x => x.MoneyPerHour()));

            Console.WriteLine("Workers:");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1}, MoneyPerHour: {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine();

            //Merging the lists and sort them by first name and last name.

            List<Human> people = new List<Human>(students.Concat(new List<Human>(workers)));

            people = people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine("People:");
            foreach (var person in people)
            {
                Console.WriteLine("{0} {1} ", person.FirstName, person.LastName);
            }
        }
    }
}