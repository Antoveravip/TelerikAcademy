using System;

namespace Shapes
{
    class TestShapes
    {
        static void Main()
        {
            Shape[] shapes = { new Triangle(5, 4),
                               new Rectangle(4, 3),
                               new Circle(5),
                               new Triangle(6.6, 2.5),
                               new Rectangle(5, 2.5),
                               new Circle(3.5),
                               new Triangle(5, 2.5),
                               new Rectangle(4.5, 2.5),
                               new Circle(5.5)
                             };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("{0,9} with dimensions: ({1} * {2}) have surface: {3:0.00}",
                    shape.GetType().Name, shape.Width, shape.Height, shape.CalculateSurface());
            }
        }
    }
}