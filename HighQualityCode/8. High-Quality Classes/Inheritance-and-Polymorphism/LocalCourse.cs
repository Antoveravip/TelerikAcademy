//-----------------------------------------------------------------------
// <copyright file="LocalCourse.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Provide information about the local academic course.
    /// </summary>
    public class LocalCourse : Course
    {
        #region Fields
        /// <summary>
        /// Laboratory where the local course is held.
        /// </summary>
        private string lab;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class with one parameters: <paramref name="name"/>.
        /// </summary>
        /// <param name="name">>Name of the course.</param>
        public LocalCourse(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class with two parameters:
        /// <paramref name="courseName"/> and <paramref name="teacherName"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class with three parameters:
        /// <paramref name="courseName"/>, <paramref name="teacherName"/> and <paramref name="students"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        /// <param name="students">List of students studying in the course.</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class with four parameters: <paramref name="courseName"/>,
        /// <paramref name="teacherName"/>, <paramref name="students"/> and <paramref name="labName"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        /// <param name="students">List of students studying in the course.</param>
        /// <param name="labName">Laboratory where the course is held.</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students, string labName)
            : base(courseName, teacherName, students)
        {
            this.Lab = labName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets laboratory where the course is held.
        /// </summary>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The Lab name is not stored! The entered lab name value is empty!");
                }

                this.lab = value;
            }
        }
        #endregion
       
        #region Methods
        /// <summary>
        /// Converts the value of <see cref="LocalCourse"/> instance to a <see cref="System.String"/>.
        /// </summary>
        /// <returns>String representation of the course info.</returns>
        public override string ToString()
        {
            string result;
            if (this.Lab != null)
            {
                result = base.ToString() + string.Format("; Lab = {0}", this.Lab) + " }";                
            }
            else
            {
                result = base.ToString() + " }";
            }

            return result;            
        }
        #endregion
    }
}