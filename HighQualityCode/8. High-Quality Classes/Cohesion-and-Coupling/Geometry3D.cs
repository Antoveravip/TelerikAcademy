//-----------------------------------------------------------------------
// <copyright file="Geometry3D.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Provides some methods for calculations of objects the 3D Euclidean space.
    /// </summary>
    public static class Geometry3D
    {  
        /// <summary>
        /// Calculates distance between two points in the 3D Euclidean space.
        /// </summary>
        /// <param name="x1">First point x-coordinate.</param>
        /// <param name="y1">First point y-coordinate.</param>
        /// <param name="z1">First point z-coordinate.</param>
        /// <param name="x2">Second point x-coordinate.</param>
        /// <param name="y2">Second point y-coordinate.</param>
        /// <param name="z2">Second point z-coordinate.</param>
        /// <returns>Distance between two points in the 3D Euclidean space.</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));

            return distance;
        }

        /// <summary>
        /// Calculates volume of 3D rectangular parallelepiped.
        /// </summary>
        /// <returns>Volume value</returns>
        public static double CalcVolume()
        {
            double volume = Geometry.Width * Geometry.Height * Geometry.Depth;

            return volume;
        }

        /// <summary>
        /// Calculates diagonal XYZ in rectangular parallelepiped.
        /// </summary>
        /// <returns>Diagonal length.</returns>
        /// <seealso cref="http://en.wikipedia.org/wiki/Cuboid"/>
        public static double CalcDiagonalXYZ()
        {
            double diagonal = Math.Sqrt(Math.Pow(Geometry.Width, 2) + Math.Pow(Geometry.Height, 2) + Math.Pow(Geometry.Depth, 2));

            return diagonal;
        }  
    }
}