using System;
using System.Drawing;

namespace FiguresLib
{

    public class Point : Figure, IEquatable<Point>
    {
        // fields
        public readonly double X, Y; //immutability

        // constructor
        public Point(double x = 0, double y = 0)
        {
            X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
            Color = Color.Blue;
        }

        public override void Draw()
        {
            Console.WriteLine($"Point({X}, {Y}), {Color}");
        }

        public bool Equals(Point other) => (other is null) ? false : (this.X == other.X && this.Y == other.Y);
        static public bool operator ==(Point p1, Point p2)
        {
            if (p1 is null && p2 is null) return true;
            if (p1 is null && !(p2 is null)) return false;

            //p1 != null
            return p1.Equals(p2);
        }
        static public bool operator !=(Point p1, Point p2) => !(p1 == p2);

    }
}
    