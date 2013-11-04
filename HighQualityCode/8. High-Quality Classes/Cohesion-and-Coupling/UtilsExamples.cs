//-----------------------------------------------------------------------
// <copyright file="UtilsExamples.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Provide some test of the classes of namespace CohesionAndCoupling.
    /// </summary>
    public class UtilsExamples
    {
        /// <summary>
        /// Test all methods from namespace CohesionAndCoupling classes.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(FileUtility.GetFileExtension("example"));
            Console.WriteLine(FileUtility.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Geometry2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Geometry3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Geometry.Width = 3;
            Geometry.Height = 4;
            Geometry.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Geometry3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Geometry3D.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Geometry2D.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Geometry2D.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Geometry2D.CalcDiagonalYZ());
        }
    }
}