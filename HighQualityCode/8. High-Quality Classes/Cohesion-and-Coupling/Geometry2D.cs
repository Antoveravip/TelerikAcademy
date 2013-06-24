//-----------------------------------------------------------------------
// <copyright file="Geometry2D.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Provides some methods for calculations of objects the 2D Euclidean space.
    /// </summary>
    public static class Geometry2D
    {
        /// <summary>
        /// Calculates distance between two points in the 2D Euclidean space.
        /// </summary>
        /// <param name="x1">First point x-coordinate.</param>
        /// <param name="y1">First point y-coordinate.</param>
        /// <param name="x2">Second point x-coordinate.</param>
        /// <param name="y2">Second point y-coordinate.</param>
        /// <returns>Distance between two points in the 2D Euclidean space.</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }   
           
        /// <summary>
        /// Calculates diagonal XY in rectangular object.
        /// </summary>
        /// <returns>Diagonal length.</returns>
        public static double CalcDiagonalXY()
        {
            double diagonal = Math.Sqrt((Geometry.Width * Geometry.Width) + (Geometry.Height * Geometry.Height));

            return diagonal;
        }

        /// <summary>
        /// Calculates diagonal XZ in rectangular object.
        /// </summary>
        /// <returns>Diagonal length.</returns>
        public static double CalcDiagonalXZ()
        {
            double diagonal = Math.Sqrt((Geometry.Width * Geometry.Width) + (Geometry.Depth * Geometry.Depth));

            return diagonal;
        }

        /// <summary>
        /// Calculates diagonal YZ in rectangular object.
        /// </summary>
        /// <returns>Diagonal length.</returns>
        public static double CalcDiagonalYZ()
        {
            double diagonal = Math.Sqrt((Geometry.Height * Geometry.Height) + (Geometry.Depth * Geometry.Depth));

            return diagonal;
        }
    }
}