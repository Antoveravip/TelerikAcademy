/* Lesson 13 - Other Algorithms
 * Homework 2
 * 
 * You are given 3 points A, B and C, forming triangle, and a
 * point P. Check if the point P is in the triangle or not.
 */

namespace PointInTriangle
{
    using System;

    // Used informations from
    // - http://www.sunshine2k.de/coding/java/PointInTriangle/PointInTriangle.html
    // - http://www.blackpawn.com/texts/pointinpoly/
    // - http://stackoverflow.com/questions/2049582/how-to-determine-a-point-in-a-triangle
    public static class PointAndTriangle
    {
        public static void Main()
        {
            Console.WriteLine("Check if the point P is in the triangle formed by given 3 points A, B and C\n");

            // TODO - before release - user input for the points
            //  Test data points and vectors
            Point3D pointA, pointB, pointC, pointP;

            // First test data
            pointA = new Point3D(1, 1, 0);
            pointB = new Point3D(2, 2, 0);
            pointC = new Point3D(0, 2, 0);
            pointP = new Point3D(1.5, 1.5, 0);
 
            Vector3D vectorA, vectorB, vectorC, vectorP;
            vectorA = new Vector3D(pointA.X, pointA.Y, pointA.Z);
            vectorB = new Vector3D(pointB.X, pointB.Y, pointB.Z);
            vectorC = new Vector3D(pointC.X, pointC.Y, pointC.Z);
            vectorP = new Vector3D(pointP.X, pointP.Y, pointP.Z);

            // Check if the point P is in the triangle or not
            bool isInTriangle = PointTriangle(vectorP, vectorA, vectorB, vectorC);
            CheckPointInTriangle(isInTriangle, pointP, pointA, pointB, pointC);

            // Second test data
            pointA = new Point3D(3.5, 3.5, 3.5);
            pointB = new Point3D(-2.5, -2.5, -2.5);
            pointC = new Point3D(-2.5, 2.5, 0);
            pointP = new Point3D(0, 0, 0);

            vectorA = new Vector3D(pointA.X, pointA.Y, pointA.Z);
            vectorB = new Vector3D(pointB.X, pointB.Y, pointB.Z);
            vectorC = new Vector3D(pointC.X, pointC.Y, pointC.Z);
            vectorP = new Vector3D(pointP.X, pointP.Y, pointP.Z);

            isInTriangle = PointTriangle(vectorP, vectorA, vectorB, vectorC);
            CheckPointInTriangle(isInTriangle, pointP, pointA, pointB, pointC);

            // Third test data
            pointA = new Point3D(5, 3.5, 8);
            pointB = new Point3D(-5.5, 6, 12);
            pointC = new Point3D(0, 2, 0);
            pointP = new Point3D(8, 8, 0);

            vectorA = new Vector3D(pointA.X, pointA.Y, pointA.Z);
            vectorB = new Vector3D(pointB.X, pointB.Y, pointB.Z);
            vectorC = new Vector3D(pointC.X, pointC.Y, pointC.Z);
            vectorP = new Vector3D(pointP.X, pointP.Y, pointP.Z);

            isInTriangle = PointTriangle(vectorP, vectorA, vectorB, vectorC);
            CheckPointInTriangle(isInTriangle, pointP, pointA, pointB, pointC);
        }

        public static bool SameSide(Vector3D vectorP, Vector3D vectorA, Vector3D vectorB, Vector3D vectorC)
        {
            Vector3D firstCrossProduct = (vectorB - vectorA).CrossProduct(vectorP - vectorA);
            Vector3D secondCrossProduct = (vectorB - vectorA).CrossProduct(vectorC - vectorA);
            bool sameSide = firstCrossProduct.DotProduct(secondCrossProduct) >= 0;

            return sameSide;
        }

        public static bool PointTriangle(Vector3D vectorP, Vector3D vectorA, Vector3D vectorB, Vector3D vectorC)
        {
            bool sameSideA = SameSide(vectorP, vectorA, vectorB, vectorC);
            bool sameSideB = SameSide(vectorP, vectorB, vectorC, vectorA);
            bool sameSideC = SameSide(vectorP, vectorC, vectorA, vectorB);

            bool isPointInTriangle = sameSideA && sameSideB && sameSideC;

            return isPointInTriangle;
        }

        public static void CheckPointInTriangle(bool isInTriangle, Point3D pointP, Point3D pointA, Point3D pointB, Point3D pointC)
        {
            if (isInTriangle)
            {
                Console.WriteLine("The point {0} is inside the triangle\n{1} {2} {3}", pointP, pointA, pointB, pointC);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The point {0} is outside the triangle\n{1} {2} {3}", pointP, pointA, pointB, pointC);
                Console.WriteLine();
            }
        }
    }
}