using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._3
{
    internal abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }




        public virtual double CalculateArea()
        {
            Console.WriteLine("CalculateArea method not implemented in this class.");
            return 0.0;
        }
    }
}
