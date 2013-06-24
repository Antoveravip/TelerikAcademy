namespace DefiningClassesPartII
{
    using System;

    public static class PointDistance
    {
        //Static method - Homework Tasks 3
        public static double Calculate3DPointDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow((Math.Abs(firstPoint.X-secondPoint.X)), 2) + Math.Pow((Math.Abs(firstPoint.Y-secondPoint.Y)), 2));
            return distance;
        }
    }
}