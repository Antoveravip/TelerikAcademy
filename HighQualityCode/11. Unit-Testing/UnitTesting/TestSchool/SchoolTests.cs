namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ASchool;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolConstructor1_ThrowsException()
        {            
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolConstructor2_ThrowsException()
        {
            School school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolConstructor3_ThrowsException()
        {
            School school = new School(" ");
        }

        [TestMethod]
        public void TestSchoolConstructor4()
        {
            School school = new School("School of Engineering sciences");

            Assert.AreEqual("School of Engineering sciences", school.Name, "School name not set correctly.");
        }

        [TestMethod]
        public void TestAddCourse1()
        {
            School school = new School("School of Engineering sciences");
            Course course = new Course("C# part 2", "Svetlin Nakov");

            school.AddCourse(course);
            Assert.AreEqual(1, school.Courses.Count, "Couldn't add the course.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddCourse2_ThrowsException()
        {
            School school = new School("School of Engineering sciences");
            school.AddCourse(null);
        }

        [TestMethod]
        public void TestRemoveCourse1()
        {
            School school = new School("School of Engineering sciences");
            Course course = new Course("C# part 2", "Svetlin Nakov");

            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.AreEqual(0, school.Courses.Count, "Couldn't remove the course.");
        }
    }
}