//-----------------------------------------------------------------------
// <copyright file="Geometry.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Provide geometry parameters as width, height and depth.
    /// </summary>
    public static abstract class Geometry
    {
        #region Fields
        /// <summary>
        /// The geometry width parameter.
        /// </summary>
        private static double width;

        /// <summary>
        /// The geometry height parameter.
        /// </summary>
        private static double height;

        /// <summary>
        /// The geometry depth parameter.
        /// </summary>
        private static double depth;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets value of width parameter.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="width"/> is zero or negative.</exception>
        public static double Width
        {
            get
            {
                return Geometry.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive. Can't have negative or zero value!");
                }

                Geometry.width = value;
            }
        }

        /// <summary>
        /// Gets or sets value of height parameter.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="height"/> is zero or negative.</exception>
        public static double Height
        {
            get
            {
                return Geometry.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive. Can't have negative or zero value!");
                }

                Geometry.height = value;
            }
        }

        /// <summary>
        /// Gets or sets value of depth parameter.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="depth"/> is zero or negative.</exception>
        public static double Depth
        {
            get
            {
                return Geometry.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth must be positive. Can't have negative or zero value!");
                }

                Geometry.depth = value;
            }
        }
        #endregion
    }
}