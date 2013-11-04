//-----------------------------------------------------------------------
// <copyright file="RotatedRectangle.cs" company="crypted info">
//  Copyright (c) crypted info. All rights reserved.
// </copyright>
// <author>crypted info</author>
//-----------------------------------------------------------------------
namespace RefactoringSize
{
    using System;
    
    /// <summary>
    /// This class take given rectangle's width and height and creates a new rectangle rotated by some angle.
    /// </summary>
    public static class RotatedRectangle
    {
        #region Methods
        /// <summary>
        /// Test <see cref="Rectangle"/> class and <see cref="RotatedRectangle"/> class.
        /// </summary>
        public static void Main()
        {
            // TODO: Test if required!
        }

        // I found useful information about refactoring of this method on: http://willperone.net/Code/coderr.php

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class rotated by angle.
        /// </summary>
        /// <param name="rectangle">Contains rectangle object</param>
        /// <param name="angle">Contains desired angle of rotation</param>
        /// <returns>New instance of rectangle class rotated by angle</returns>        
        public static Rectangle GetRotatedRectabgle(Rectangle rectangle, double angle)
        {
            double sin = CalculateSinus(angle);
            double cos = CalculateCosine(angle);

            double rotatedWidth = (cos * rectangle.Width) + (sin * rectangle.Height);
            double rotatedHeight = (sin * rectangle.Width) + (cos * rectangle.Height);

            Rectangle rotadedRectangle = new Rectangle(rotatedWidth, rotatedHeight);
            
            return rotadedRectangle;
        }

        /// <summary>
        /// Calculate sinus from given angle
        /// </summary>
        /// <param name="angle">Contains value of angle</param>
        /// <returns>Absolute value of sinus from angle</returns>
        public static double CalculateSinus(double angle)
        {
            double sinus = Math.Sin(angle);

            // This code is instead 
            // Math.Abs(sin);
            if (sinus < 0)
            {
                sinus = -sinus;
            }

            return sinus;
        }

        /// <summary>
        /// Calculate cosine from given angle
        /// </summary>
        /// <param name="angle">Contains value of angle</param>
        /// <returns>Absolute value of cosine from angle</returns>
        public static double CalculateCosine(double angle)
        {
            double cosine = Math.Cos(angle);

            // This code is instead 
            // Math.Abs(cos);
            if (cosine < 0)
            {
                cosine = -cosine;
            }

            return cosine;
        }
        #endregion
    }
}