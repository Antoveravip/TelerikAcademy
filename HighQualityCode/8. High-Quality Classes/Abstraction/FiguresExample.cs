//-----------------------------------------------------------------------
// <copyright file="FiguresExample.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace Abstraction
{
    using System;

    /// <summary>
    /// Test the <see cref="Circle"/> and <see cref="Rectangle"/> classes.
    /// </summary>
    public static class FiguresExample
    {
        #region Methods
        /// <summary>
        /// Initializes an instance of the <see cref="Circle"/> and <see cref="Rectangle"/> classes and test their methods.
        /// </summary>
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.Write("I am a circle. ");
            Console.WriteLine("My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalcPerimeter(), circle.CalcArea());

            Rectangle rect = new Rectangle(2, 3);
            Console.Write("I am a rectangle. ");
            Console.WriteLine("My perimeter is {0:f2}. My surface is {1:f2}.", rect.CalcPerimeter(), rect.CalcArea());
        }
        #endregion
    }
}