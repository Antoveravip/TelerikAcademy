namespace TestSchool
{
    using System;
    using ASchool;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentConstructor1_ThrowsException()
        {
            Student anonymous = new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentConstructor2_ThrowsException()
        {
            Student anonymous = new Student(" ");
        }

        [TestMethod]
        public void TestStudentConstructor3()
        {
            Student pavelIvanov = new Student("Pavel Ivanov");

            Assert.AreEqual("Pavel Ivanov", pavelIvanov.Name, "Student's name is not set correctly.");
        }       

        [TestMethod]
        public void TestStudentConstructor4()
        {
            Student pavelIvanov = new Student("Pavel Ivanov", 10500);

            Student pavelKolev = new Student("Pavel Kolev", 10501);

            Assert.IsTrue(pavelIvanov.FacultyNumber == (pavelKolev.FacultyNumber - 1), "Student FacultyNumber's don't have consecutive values.");
        }

        [TestMethod]
        public void TestStudentToString1()
        {
            Student pavelIvanov = new Student("Pavel Ivanov", 10500);

            Assert.AreEqual(
                string.Format("{{ Faculty Number = {0}, Name = Pavel Ivanov }}", pavelIvanov.FacultyNumber),
                pavelIvanov.ToString(),
                "Student.ToString() is not correct.");
        }
    }
}