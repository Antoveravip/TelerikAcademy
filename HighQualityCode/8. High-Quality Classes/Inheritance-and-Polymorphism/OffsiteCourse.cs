//-----------------------------------------------------------------------
// <copyright file="OffsiteCourse.cs" company="Telerik Academy">
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
    /// Provide information about the offsite academic course.
    /// </summary>
    public class OffsiteCourse : Course
    {
        #region Fields
        /// <summary>
        /// Town where the offsite course is held.
        /// </summary>
        private string town;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class with one parameters: <paramref name="name"/>.
        /// </summary>
        /// <param name="name">>Name of the course.</param>
        public OffsiteCourse(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class with two parameters:
        /// <paramref name="courseName"/> and <paramref name="teacherName"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class with three parameters:
        /// <paramref name="courseName"/>, <paramref name="teacherName"/> and <paramref name="students"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        /// <param name="students">List of students studying in the course.</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class with four parameters: <paramref name="courseName"/>,
        /// <paramref name="teacherName"/>, <paramref name="students"/> and <paramref name="townName"/>.
        /// </summary>
        /// <param name="courseName">>Name of the course.</param>
        /// <param name="teacherName">Name of a teacher leading a course.</param>
        /// <param name="students">List of students studying in the course.</param>
        /// <param name="townName">Town where the course is held.</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string townName)
            : base(courseName, teacherName, students)
        {
            this.Town = townName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets town where the course is held.
        /// </summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The town name is not stored! The entered town name value is empty!");
                }

                this.town = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts the value of <see cref="OffsiteCourse"/> instance to a <see cref="System.String"/>.
        /// </summary>
        /// <returns>String representation of the course info.</returns>
        public override string ToString()
        {
            string result;
            if (this.Town != null)
            {
                result = base.ToString() + string.Format("; Town = {0}", this.Town) + " }";                
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