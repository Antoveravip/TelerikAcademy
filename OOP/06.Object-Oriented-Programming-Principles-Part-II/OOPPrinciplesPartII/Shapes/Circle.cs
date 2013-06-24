using System;

namespace Shapes
{
    class Circle : Shape
    {
        // --- CONSTRUCTORS --- //
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentNullException("Radius value must be posive number!");
            }
            else
            {
                this.Width = radius;
                this.Height = radius;
            }
        }

        // --- METHODS --- //
        //Implement the virual method from Shape
        public override double CalculateSurface()
        {
            return (this.Height * this.Width * Math.PI);
        }
    }
}