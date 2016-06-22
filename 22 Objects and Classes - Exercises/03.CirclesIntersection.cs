using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }

            public static string Intersect(Circle c1, Circle c2)
            {
                bool doTheyIntersect = false;
                double a = Math.Abs(c1.Center.X - c2.Center.X);
                double b = Math.Abs(c1.Center.Y - c2.Center.Y);
                double c = Math.Sqrt(a * a + b * b);

                if (c <= c1.Radius + c2.Radius)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        static void Main()
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            circle1 = ReadInfo();
            circle2 = ReadInfo();

            Console.WriteLine(Circle.Intersect(circle1, circle2));
        }

        public static Circle ReadInfo()
        {
            double[] info = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle c1 = new Circle();
            Point p1 = new Point() { X = info[0], Y = info[1] };
            c1.Center = p1;
            c1.Radius = info[2];

            return c1;
        }
    }
}

