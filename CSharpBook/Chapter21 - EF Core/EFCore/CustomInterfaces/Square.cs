using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Square : Shape, IRegularPointy
    {
        public Square()
        {

        }
        public Square(string name) : base(name)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"{PetName} is a Square !");
        }
        //IPointy 
        public byte Points => 4;
        //IRegularPointy
        public int SideLength{get; set;}
        public int NumberOfSides { get; set;}
        //perimeter property not implemented

    }
}
