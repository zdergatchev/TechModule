using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return "Point(" + X + ", " + Y + ")";
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            Console.WriteLine("{0:f3}", CalcDistance(p1, p2));
        }

        static Point ReadPoint()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = nums[0], Y = nums[1] };
            return p;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p1.X - p2.X;
            var deltaY = p1.Y - p2.Y;
            var d = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return d;
        }
    }
}
