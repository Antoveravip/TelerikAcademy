namespace ASchool
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class School
    {
        #region Fields

        private string name;
        private IList<Course> courses;

        #endregion

        #region Constructors

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value cannot be null or empty.", "value");
                }

                this.name = value;
            }
        }

        public IList<Course> Courses
        {
            get
            {
                return new ReadOnlyCollection<Course>(this.courses);
            }
        }

        #endregion

        #region Public Methods

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "course cannot be null.");
            }

            this.courses.Add(course);
        }

        public bool RemoveCourse(Course course)
        {
            return this.courses.Remove(course);
        }

        #endregion
    }
}