//-----------------------------------------------------------------------
// <copyright file="Figure.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    /// Abstract class for geometric figures
    /// </summary>
    public abstract class Figure
    {
        #region Abstract Methods
        /// <summary>
        /// Calculates perimeter of geometric figure. 
        /// </summary>
        /// <returns>The perimeter value.</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates area of geometric figure. 
        /// </summary>
        /// <returns>The area value.</returns>
        public abstract double CalcArea();
        #endregion
    }
}