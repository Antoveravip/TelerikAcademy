//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    /// Represent the geometric figure rectangle.
    /// </summary>
    public class Rectangle : Figure
    {
        #region Fields
        /// <summary>
        /// The rectangle width parameter.
        /// </summary>
        private double width;

        /// <summary>
        /// The rectangle height parameter.
        /// </summary>
        private double height;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width parameter of the rectangle.</param>
        /// <param name="height">The height parameter of the rectangle.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets and private sets value of rectangle width parameter.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="width"/> is zero or negative.</exception>
        public double Width
        {
            get
            { 
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive. Can't have negative or zero value!");
                }

                this.width = value; 
            }
        }

        /// <summary>
        /// Gets and private sets value of rectangle height parameter.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="height"/> is zero or negative.</exception>
        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive. Can't have negative or zero value!");
                }

                this.height = value; 
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates perimeter of rectangle. 
        /// </summary>
        /// <returns>The perimeter value.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        /// <summary>
        /// Calculates area of rectangle
        /// </summary>
        /// <returns>The area value.</returns>
        public override double CalcArea()
        {
            double area = this.Width * this.Height;

            return area;
        }
        #endregion
    }
}