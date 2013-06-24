using System;

namespace Shapes
{
    class Rectangle : Shape
    {
        // --- CONSTRUCTORS --- //
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        // --- METHODS --- //
        //Implement the virual method from Shape
        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }
    }
}