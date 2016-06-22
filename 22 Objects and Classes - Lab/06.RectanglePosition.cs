using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        int Left { get; set; }
        int Top { get; set; }
        int Width { get; set; }
        int Height { get; set; }

        public int Right
        {
            get { return Left + Width; }
        }
        public int Bottom
        {
            get { return Top + Height; }
        }

        public bool IsInside(Rectangle r)
        {
            return r.Left <= Left && r.Top <= Top &&
                    r.Right >= Right && r.Bottom >= Bottom;
        }
    }

    public class RectanglePositionMain
    {
        public static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            bool isInside = firstRectangle.IsInside(secondRectangle);

            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }    

        public static Rectangle ReadRectangle()
        {
            int[] coordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Rectangle rectangle = new Rectangle() 
            {
                Left = coordinates[0],
                Top = coordinates[1],
                Width = coordinates[2],
                Height = coordinates[3]
            };
            return rectangle;
        }
    }
}

