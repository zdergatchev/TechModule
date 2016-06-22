using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {            
            Point[] points = ReadPoints();
            var closestPoints = FindClosestTwoPoints(points);
            Console.WriteLine("{0:f3}", CalcDistance(
               closestPoints[0], closestPoints[1]));
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }  

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static Point ReadPoint()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = nums[0], Y = nums[1] };
            return p;
        }

        static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n; i++)
                points[i] = ReadPoint();
            return points;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p2.X - p1.X;
            var deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    var distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;
        }
    }
}
