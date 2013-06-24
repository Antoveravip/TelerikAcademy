namespace PointInTriangle
{
    public class Point3D
    {
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            string result = string.Format("Point({0}, {1}, {2})", this.X, this.Y, this.Z);
            return result;
        }
    }
}