namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        // --- FIELDS --- //
        private string classID;
        private List<Teacher> teachers;
        private List<Student> students;
        private string comments;

        // --- PROPERTIES --- //
        public string ClassID
        {
            get
            {
                return this.classID;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Class ID must be properly set!");
                }
                this.classID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                if (this.teachers.Count == 0)
                {
                    throw new ArgumentNullException("No available teacher at this moment!");
                }
                return this.teachers;
            }
        }

        public List<Student> Students
        {
            get
            {
                if (this.students.Count == 0)
                {
                    throw new ArgumentNullException("There are no available students!");
                }
                return this.students;
            }
        }

        public string Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        // --- CONSTRUCTORS --- //
        public Class(string classID)
        {
            this.classID = classID;
        }

        public Class(string classID, List<Teacher> teachers, List<Student> students)
            : this(classID, teachers, students, null)
        {
        }

        public Class(string classID, List<Teacher> teachers, List<Student> students, string comments)
        {
            this.classID = classID;
            this.teachers = teachers;
            this.students = students;
            this.comments = comments;
        }

        // --- METHODS --- //
        public void AddTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                throw new ArgumentException("The teacher was been already added!");
            }
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                this.teachers.Remove(teacher);
            }
            else
            {
                throw new ArgumentNullException("There is no such teacher!");
            }
        }

        public void AddStudent(Student student)
        {
            if (students.Contains(student))
            {
                throw new ArgumentException("The student was been already added!");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (students.Contains(student))
            {
                this.students.Remove(student);
            }
            else
            {
                throw new ArgumentNullException("There is no such student!");
            }
        }
    }
}