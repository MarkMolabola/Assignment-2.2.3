using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._3
{
    internal class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle(int id, string name, string color, double radius)
        {
            Id = id;
            Name = name;
            Color = color;
            Radius = radius;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
