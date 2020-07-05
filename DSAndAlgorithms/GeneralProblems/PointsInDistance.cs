using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
    public class PointsInDistance
    {
        public static List<Point> GetPointsWithinDistance(List<Point> listPoints, Point mainPoint, double distance)
        {
            List<Point> validPoints = new List<Point>();
            foreach (var p in listPoints)
            {
                if (mainPoint.IsWithinAdistance(p, distance))
                {
                    validPoints.Add(p);
                }
            }
            foreach (var p in validPoints)
            {
                Console.WriteLine(p.X.ToString() + "," + p.Y.ToString());
            }
            return validPoints;
        }
    }
    public class Point
    {
       public double X { get; }

        public double Y { get; }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public double GetDistance(Point otherPoint)
        {
         return   Math.Sqrt(Math.Pow(otherPoint.X - X,2) + Math.Pow(otherPoint.Y - Y,2));
        }
        public bool IsWithinAdistance(Point otherPoint,double distance)
        {
            if (Math.Abs(otherPoint.X - X) > distance || Math.Abs(otherPoint.Y - Y) > distance)
            {
                return false;
            }
           return GetDistance(otherPoint) <= distance;

        }
    }
}
