using System;

namespace DefiningClassesPartII
{
    public struct Point3D
    {
        // --- FIELDS --- //
        //Characteristics fields 
        private int x, y, z;                    // - Homework Tasks 1
        private static readonly Point3D coordinateZero = new Point3D(0, 0, 0);  // - Homework Tasks 2

        // --- PROPERTIES --- //
        //Properties - Homework Tasks 1
        public int X
        { 
            get { return x; } 
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        //Static property - Homework Tasks 2
        public static Point3D Zero
        {
            get { return coordinateZero; }
        }


        // --- CONSTRUCTORS --- //
        public Point3D(int x, int y, int z)
            : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        // --- METHODS --- //
        //Override ToString() - Homework Tasks 1
        public override string ToString()
        {
            string Point3D = string.Format("({0},{1},{2})", X, Y, Z);
            return Point3D;
        }
    }
}