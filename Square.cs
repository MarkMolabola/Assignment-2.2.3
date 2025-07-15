using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._3
{
    internal class Square: Shape
    {
        public double SideLength { get; set; }
        public Square(int id, string name, string color, double sideLength)
        {
            Id = id;
            Name = name;
            Color = color;
            SideLength = sideLength;
        }
        public Square(double sideLength)
        {
           SideLength = sideLength;
        }
        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
