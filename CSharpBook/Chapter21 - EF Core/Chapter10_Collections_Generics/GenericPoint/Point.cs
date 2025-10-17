using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    public struct Point<T>
    {
        private T _xPos;
        private T _yPos;

        public Point(T x, T y)
        {
            _xPos = x;
            _yPos = y;
        }
        public T X { get => _xPos; set => _xPos = value; }
        public T Y { get => _yPos; set => _yPos = value; }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
        public void ResetPoint()
        {
            X = default;
            Y = default;
        }
        public T Add(T arg1, T arg2)
        { return arg1 + arg2; }
        public T Subtract(T arg1, T arg2)
        { return arg1 - arg2; }
        public T Multiply(T arg1, T arg2)
        { return arg1 * arg2; }
        public T Divide(T arg1, T arg2)
        { return arg1 / arg2; }
    }
}
