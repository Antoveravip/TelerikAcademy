using System;
using System.Collections.Generic;

namespace DefiningClassesPartII
{
    public class Path
    {
        private List<Point3D> pointsData = new List<Point3D>();

        public List<Point3D> PointStorage
        {
            get 
            {
                return this.pointsData;
            }
        }

        public void AddPoint(Point3D point)
        {
            pointsData.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            try
            {
                pointsData.Remove(point);
            }
            catch (Exception)
            {

                throw new NullReferenceException("This point is not found in stored points data!"); ;
            }                
        }

        public void ClearAllPoints()
        {
            pointsData.Clear();
        }
    }
}