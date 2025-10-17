using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    internal class Point: ICloneable
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public PointDescription Description = new PointDescription();
        public Point()
        {
            
        }
        public Point(int x, int y, string petname)
        {
            X = x; Y=y;
            Description.PetName = petname;
        }
        public override string ToString()
        {
            return $"X = {X}; Y = {Y}; Name = {Description.PetName}; \nID = {Description.PointID}\n";
        }

        public object Clone()
        {
            return new Point(X, Y, Description.PetName);
        }
    }
}
