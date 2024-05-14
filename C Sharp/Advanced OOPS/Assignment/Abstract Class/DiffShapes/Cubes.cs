using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiffShapes
{
    public class Cubes : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }
        public Cubes(double area, double volume, double radius, double height, double width, double a) : base(area, volume)
        {
            Area = area;
            Volume = volume;
        }
        public Cubes(double a)
        {
            A = a;
        }
        public override double CalculateArea()
        {
            Area = 6 * A* A;
            return Area;
        }
        public override double CalculateVolume()
        {
            Volume = A* A* A;
            return Volume;
        }
    }
}