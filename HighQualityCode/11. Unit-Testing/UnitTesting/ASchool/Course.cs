namespace ASchool
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;

    public class Course
    {
        #region Constants

        public const int MaxStudentsCount = 29;

        #endregion

        #region Fields

        private string name;
        private string lectorName;
        private IList<Student> students;

        #endregion

        #region Constructors

        public Course(string name, string lectorName)
        {
            this.Name = name;
            this.LectorName = lectorName;
            this.students = new List<Student>();
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

        public string LectorName
        {
            get
            {
                return this.lectorName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value cannot be null or empty.", "value");
                }

                this.lectorName = value;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return new ReadOnlyCollection<Student>(this.students);
            }
        }

        #endregion

        #region Public Methods

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "student cannot be null.");
            }

            if (this.students.Count == MaxStudentsCount)
            {
                throw new InvalidOperationException(
                    string.Format(
                    "Student cannot be added. Course attendants have reached the maximum number ({0}).",
                    MaxStudentsCount));
            }

            this.students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            return this.students.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name = {0}", this.Name);

            result.AppendFormat("; Lector = {0}", this.LectorName);

            result.AppendFormat("; Students = {0}", this.GetStudentsAsString());

            return result.ToString();
        }

        #endregion

        #region Private Methods

        private string GetStudentsAsString()
        {
            if (this.students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.students) + " }";
            }
        }

        #endregion
    }
}