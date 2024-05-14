using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaDiffShapes
{
    public class Sphere : Dimension
    {
        public double Radius {get; set;}
        public Sphere(double value1, double value2, double area, double radius) : base( value1,  value2,  area)
        {
            Radius = radius;
        }
        public override double Calculate()
        {
            Area = 4*3.14*Radius*Radius;
            return Area;
        }
        public override double DisplayArea()
        {
            return Area;
        }
    }
}