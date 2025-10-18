using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    public class Point : IComparable<Point>
    {
        private int _xPos;
        private int _yPos;

        public Point(int x, int y)
        {
            _xPos = x;
            _yPos = y;
        }
        public int X { get => _xPos; set => _xPos = value; }
        public int Y { get => _yPos; set => _yPos = value; }

        public override string ToString()
        {
            return $"[{this.X}, {this.Y}]";
        }
        public void ResetPoint()
        {
            X = default;
            Y = default;
        }
        public static Point operator +(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator +(Point p1, int change) => new Point(p1.X + change, p1.Y + change);
        public static Point operator +(int change, Point p1) => new Point(p1.X + change, p1.Y + change);
        public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);
        public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);


        public static Point operator -(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);
        public static Point operator -(Point p1, int change) => new Point(p1.X - change, p1.Y - change);
        public static Point operator -(int change, Point p1) => new Point(change - p1.X, change - p1.Y);

        public override bool Equals(object obj)
        {
            if (obj.ToString() == this.ToString()) return true;
            return false;
        }

        public int CompareTo(Point p)
        {
            if (this.X > p.X && this.Y > p.Y) return 1;
            if (this.X < p.X && this.Y < p.Y) return -1;
            return 0;
        }
        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;
        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;
        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);
    }
}
