//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="crypted info">
//  Copyright (c) crypted info. All rights reserved.
// </copyright>
// <author>crypted info</author>
//-----------------------------------------------------------------------

namespace RefactoringSize
{
    using System;

    /// <summary>
    /// This class defines and creates a rectangle by given width and height.
    /// </summary>
    public class Rectangle
    {
        #region Fields
        /// <summary>
        /// Field store for width property. 
        /// </summary>
        private double width;

        /// <summary>
        /// Field store for height property. 
        /// </summary>
        private double height;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">Contains the width value.</param>
        /// <param name="height">Contains the height value.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets rectangle's width value
        /// </summary>
        /// <value> 
        /// Width value must be positive double number.
        /// </value> 
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Width must be a positive number");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets rectangle's height value
        /// </summary>
        /// <value> 
        /// Height value must be positive double number.
        /// </value> 
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Height must be a positive number");
                }

                this.height = value;
            }
        }
        #endregion
    }
}