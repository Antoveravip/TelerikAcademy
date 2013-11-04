namespace ASchool
{
    using System;

    public class Student
    {
        #region Constant

        private const int facultyMinValue = 10000;
        private const int facultyMaxValue = 99999;

        #endregion

        #region Fields

        private string name;
        private int facultyNumber;
        private int nextFacultyNumber;
        private int currentFacultyNumber = 10000;

        #endregion

        #region Constructors

        public Student(string name)
        {
            this.Name = name;
            this.FacultyNumber = this.FacultyNumberGenerator();
        }

        public Student(string name, int facultyNumber)
        {
            this.Name = name;
            this.FacultyNumber = facultyNumber;
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

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value >= facultyMinValue && value <= facultyMaxValue)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The unique faculty number of student" + this.Name +
                        "should be between 10000 and 99999!");
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            string data = string.Format("{{ Faculty Number = {0}, Name = {1} }}", this.FacultyNumber, this.Name);

            return data;
        }
        
        private int FacultyNumberGenerator()
        {
            nextFacultyNumber = currentFacultyNumber;
            int generatedFacultyNumber = nextFacultyNumber;

            if (generatedFacultyNumber == facultyMaxValue)
            {
                nextFacultyNumber = facultyMinValue;
            }
            else
            {
                nextFacultyNumber++;
            }

            currentFacultyNumber = generatedFacultyNumber;

            return generatedFacultyNumber;
        }

        #endregion
    }
}