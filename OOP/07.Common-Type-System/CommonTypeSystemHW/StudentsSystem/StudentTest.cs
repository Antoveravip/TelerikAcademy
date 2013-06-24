namespace StudentsSystem
{
    using System;
    using System.Collections.Generic;

    class StudentTest
    {
        static void Main()
        {
            //Creating some test students
            Student firstStudent = new Student("Kamen", "Ivanov", "Popov", "099123456", "Sofia, 25 Madrid Blvd", "359888999777",
                "shopov@gmail.com", University.SU, Faculty.Physic, Specialty.QAEngineer, 2);
            Student secondStudent = new Student("Anna", "Stoyanova", "Ivanova", "959456123", "Varna, 25 Vladislav Varnenchik Blvd", "359878777666",
                "ivanova@gmail.com", University.NBU, Faculty.IT, Specialty.SoftwareEngineering, 1);
            Student thirdStudent = new Student("Petya", "Petrova", "Spasova", "129115474", "Plovdiv, 11 Maritca Str", "359867585123",
                "spasova@abv.bg", University.TU, Faculty.Mathematics, Specialty.CommunicationTechnology, 4);
            Student fourthStudent = new Student("Ivan", "Kirilov", "Petrov", "357583746", "Bourgas, 116 Cherno more Str", "359886875214",
                "petrov@gmail.com", University.SU, Faculty.IT, Specialty.DotNETDeveloper, 3);
            Student fifthStudent = new Student("Plamen", "Kostov", "Borisov", "475158476", "Sofia, 125 Tzaritza Joanna Blvd", "359897124758",
                "borisov@gabv.bg", University.MU, Faculty.Biology, Specialty.Bioinformatics, 1);

            //Testing clone, equals and other
            Console.WriteLine("Origin:\n{0}", secondStudent);
            Console.WriteLine(new string('-', 79));

            Student clonedStudent = secondStudent.Clone();
            Console.WriteLine("Cloned:\n{0}", clonedStudent);
            Console.WriteLine(new string('-', 79));

            Console.WriteLine("Second and cloned students are one person: {0}", secondStudent.Equals(clonedStudent));
            Console.WriteLine(new string('-', 79));

            clonedStudent.SSN = "959875121";
            Console.WriteLine("The cloned student have new SSN:\n{0}", clonedStudent);
            Console.WriteLine(new string('-', 79));

            Console.WriteLine("Did they now one person? {0}", clonedStudent.Equals(secondStudent));
            Console.WriteLine(new string('-', 79));

            Console.WriteLine("All students in our test system are:");
            Console.WriteLine(new string('-', 79));

            Console.WriteLine(firstStudent);
            Console.WriteLine(new string('-', 79));

            Console.WriteLine(secondStudent);
            Console.WriteLine(new string('-', 79));

            Console.WriteLine(thirdStudent);
            Console.WriteLine(new string('-', 79));

            Console.WriteLine(fourthStudent);
            Console.WriteLine(new string('-', 79));

            Console.WriteLine(fifthStudent);
            Console.WriteLine(new string('-', 79));

            //Sorting students

            List<Student> studentsSort = new List<Student>();
            studentsSort.Add(fifthStudent);
            studentsSort.Add(secondStudent);
            studentsSort.Add(thirdStudent);
            studentsSort.Add(fourthStudent);
            studentsSort.Add(fifthStudent);

            studentsSort.Sort();

            Console.WriteLine("After sorting the studens list is:");

            foreach (Student student in studentsSort)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('-', 79));
            }
        }
    }
}