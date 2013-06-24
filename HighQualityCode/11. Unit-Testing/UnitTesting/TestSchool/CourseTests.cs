namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ASchool;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void TestCourseConstructor1()
        {
            Course course = new Course("Math", "Iliana Popova");

            Assert.AreEqual("Math", course.Name, "Course name not set correctly.");
        }

        [TestMethod]
        public void TestCourseConstructor2()
        {
            Course course = new Course("Math", "Iliana Popova");

            Assert.AreEqual("Iliana Popova", course.LectorName, "Course lector not set correctly.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructor3_ThrowsException()
        {
            Course course = new Course(null, "Iliana Popova");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructor4_ThrowsException()
        {
            Course course = new Course(string.Empty, "Iliana Popova");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructor5_ThrowsException()
        {
            Course course = new Course(" ", "Iliana Popova");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructor6_ThrowsException()
        {
            Course course = new Course("OOP", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructor7_ThrowsException()
        {
            Course course = new Course("KPK", string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseConstructor8_ThrowsException()
        {
            Course course = new Course("JS", " ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddStudent1_ThrowsException()
        {
            Course course = new Course("OOP", "Nikolai Kostov");
            course.AddStudent(null);
        }

        [TestMethod]
        public void TestAddStudent2()
        {
            Course course = new Course("OOP", "Nikolai Kostov");
            Student kamenDonev = new Student("Kamen Donev", 10001);
            course.AddStudent(kamenDonev);

            Assert.AreEqual(1, course.Students.Count, "Couldn't add the student to the course.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddStudent3_ThrowsException()
        {
            Course course = new Course("OOP", "Nikolai Kostov");
            for (int i = 0; i < Course.MaxStudentsCount + 1; i++)
            {
                course.AddStudent(new Student("Kamen Donev", 10001));
            }
        }

        [TestMethod]
        public void TestRemoveStudent1()
        {
            Course course = new Course("OOP", "Nikolai Kostov");
            Student kalinSpasov = new Student("Kalin Spasov", 99989);
            course.AddStudent(kalinSpasov);
            bool studentRemoved = course.RemoveStudent(kalinSpasov);

            Assert.AreEqual(true, studentRemoved, "Couldn't remove student.");
            Assert.AreEqual(0, course.Students.Count, "Couldn't remove student.");
        }

        [TestMethod]
        public void TestRemoveStudent2()
        {
            Course course = new Course("OOP", "Nikolai Kostov");
            Student kalinSpasov = new Student("Kalin Spasov");
            course.AddStudent(kalinSpasov);
            bool studentRemoved = course.RemoveStudent(new Student("Ward Cunningham"));

            Assert.AreEqual(false, studentRemoved, "Non-existent student removed.");
            Assert.AreEqual(1, course.Students.Count, "Non-existent student removed.");
        }

        [TestMethod]
        public void TestRemoveStudent3()
        {
            Course course = new Course("OOP", "Nikolai Kostov");
            Student kalinSpasov = new Student("Kalin Spasov");
            course.AddStudent(kalinSpasov);
            bool studentRemoved = course.RemoveStudent(null);

            Assert.AreEqual(false, studentRemoved, "Non-existent student removed.");
            Assert.AreEqual(1, course.Students.Count, "Non-existent student removed.");
        }

        [TestMethod]
        public void TestCourseToString1()
        {
            Course course = new Course("OOP", "Nikolai Kostov");

            Student kalinSpasov = new Student("Kalin Spasov", 10010);
            Student andrewTanenbaum = new Student("Nikolai Kostov");

            course.AddStudent(kalinSpasov);
            course.AddStudent(andrewTanenbaum);

            Assert.AreEqual(
                string.Format(
                "Name = OOP; Lector = Nikolai Kostov; Students = {{ {0}, {1} }}",
                kalinSpasov,
                andrewTanenbaum),
                course.ToString(),
                "Course.ToString() is not correct.");
        }

        [TestMethod]
        public void TestCourseToString2()
        {
            Course course = new Course("JS", "Doncho Minkov");

            Assert.AreEqual(
                "Name = JS; Lector = Doncho Minkov; Students = { }",
                course.ToString(),
                "Course.ToString() is not correct.");
        }
    }
}