using System;

namespace Shapes
{
    abstract class Shape
    {
        // --- FIELDS --- //
        private double width;
        private double height;

        // --- PROPERTIES --- //
        public double Width
        {
            get { return this.width; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The width value must be positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The height value must be positive number!");
                }
                this.height = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Shape()
            : this(0, 0)
        { }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // --- METHODS --- //
        public abstract double CalculateSurface();
    }
}