namespace StudentsSystem
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        // --- FIELDS --- //
        private string firstName;
        private string middleName;
        private string lastName;
        private string sSN;
        private string permanentAddress;
        private string mobilePhone;
        private string eMail;
        private University universityName;
        private Faculty facultyName;
        private Specialty specialtyName;
        private byte? course;

        // --- PROPERTIES --- //
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public University UniversityName { get; set; }
        public Faculty FacultyName { get; set; }
        public Specialty SpecialtyName { get; set; }
        public byte? Course { get; set; }

        // --- CONSTRUCTORS --- //
        public Student(string firstName, string middleName, string lastName, string sSN, string permanentAddress, string mobilePhone,
            string eMail, University universityName, Faculty facultyName, Specialty specialtyName, byte? course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.UniversityName = universityName;
            this.FacultyName = facultyName;
            this.SpecialtyName = specialtyName;
            this.Course = course;
        }

        public Student(string firstName, string middleName, string lastName, string sSN, string permanentAddress, string mobilePhone, string eMail)
            : this(firstName, middleName, lastName, sSN, permanentAddress, mobilePhone, eMail, University.Unspecified, Faculty.Unspecified,
                    Specialty.Unspecified, null)
        {
        }

        public Student(string firstName, string middleName, string lastName, string sSN)
            : this(firstName, middleName, lastName, sSN, null, null, null, University.Unspecified, Faculty.Unspecified,
                    Specialty.Unspecified, null)
        {
        }

        public Student(string firstName, string lastName, string sSN, University universityName, Faculty facultyName, Specialty specialtyName, byte? course)
            : this(firstName, null, lastName, sSN, null, null, null, universityName, facultyName, specialtyName, course)
        {
        }

        public Student(string sSN, University universityName, Faculty facultyName, Specialty specialtyName, byte? course)
            : this(null, null, null, sSN, null, null, null, universityName, facultyName, specialtyName, course)
        {
        }

        // --- METHODS --- //

        //Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        //Override the standard method Equals().
        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;

            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }

            // Compare the reference type member fields
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }

        //Override the standard method ToString().
        public override string ToString()
        {
            return String.Format(
                "Name: {0} {1} {2}, SSN: {3},\nPerson Info: {4} {5} {6}\nStudent Info: {7} {8} {9}, Course: {10};)", this.FirstName ?? "unnamed",
                this.MiddleName ?? "", this.LastName ?? "unnamed", this.SSN ?? "none", this.PermanentAddress ?? "unknown", this.MobilePhone ?? "", 
                this.EMail ?? "", this.UniversityName, this.FacultyName, this.SpecialtyName, this.Course);
        }

        //Override the standard method GetHashCode().
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        //Override the operator ==
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        //Override the operator !=
        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        //Implementations of the ICloneable interface - task 2
        public Student Clone()                                 //Deep cloning (public method)
        {
            Student originalStudent = this;
            Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.MobilePhone, this.EMail, this.UniversityName, this.FacultyName, this.SpecialtyName, this.Course);

            return clonedStudent;
        }
        // Implicit interface implementation
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        //Implementations of the IComparable<Student> interface - task 3
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN.CompareTo(student.SSN));
            }
            return 0;
        }
    }
}