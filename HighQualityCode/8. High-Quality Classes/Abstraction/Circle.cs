//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    /// Represent the geometric figure circle.
    /// </summary>
    public class Circle : Figure
    {
        #region Constants
        /// <summary>
        /// Mathematic constant PI.
        /// </summary>
        private const double PI = Math.PI;
        #endregion

        #region Fields
        /// <summary>
        /// The circle radius parameter.
        /// </summary>
        private double radius;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius parameter of the circle.</param>        
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets and private sets value of circle radius parameter.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="radius"/> is zero or negative.</exception>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be positive. Can't have negative or zero value!");
                }

                this.radius = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates perimeter of circle. 
        /// </summary>
        /// <returns>The perimeter value.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * PI * this.Radius;

            return perimeter;
        }

        /// <summary>
        /// Calculates area of circle
        /// </summary>
        /// <returns>The area value.</returns>
        public override double CalcArea()
        {
            double area = PI * this.Radius * this.Radius;

            return area;
        }
        #endregion
    }
}