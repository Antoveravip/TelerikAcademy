//-----------------------------------------------------------------------
// <copyright file="Course.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;

    /// <summary>
    /// Provide basic information about the typical academic course.
    /// </summary>
    public abstract class Course
    {
        #region Fields
        /// <summary>
        /// Name of the course.
        /// </summary>
        private string name;

        /// <summary>
        /// Name of a teacher leading a course.
        /// </summary>
        private string teacherName;

        /// <summary>
        /// List of students studying in the course.
        /// </summary>
        private IList<string> students;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class with one parameter <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Name of the course.</param>
        protected Course(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class with two parameters:
        /// <paramref name="courseName"/> and <paramref name="teacherName"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        protected Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class with three parameters:
        /// <paramref name="courseName"/>, <paramref name="teacherName"/> and <paramref name="students"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        /// <param name="students">List of students studying in the course.</param>
        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets name of the course.
        /// </summary>
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
                    throw new ArgumentNullException("Name is not stored! The entered name value is empty!");
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentOutOfRangeException("Not correct name! Name must be at least three characters!");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Not correct name! The name must be a maximum of 50 characters!");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets name of a teacher leading a course.
        /// </summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher name is not stored! The entered name value is empty!");
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentOutOfRangeException("Not correct teacher name! Name must be at least three characters!");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Not correct teacher name! The name must be a maximum of 50 characters!");
                }

                this.teacherName = value;
            }
        }

        /// <summary>
        /// Gets or sets list of students studying in the course.
        /// </summary>
        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value != null)
                {
                    this.students = new List<string>();

                    foreach (string student in value)
                    {
                        this.students.Add(string.Copy(student));
                    }
                }
                else
                {
                    throw new ArgumentNullException("Students list can't be empty!");
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts the value of <see cref="Course"/> instance to a <see cref="System.String"/>.
        /// </summary>
        /// <returns>String representation of the course info.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        /// <summary>
        /// Converts the list of students into a string.
        /// </summary>
        /// <returns>String which contains all the names in the students list.</returns>
        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
        #endregion
    }
}