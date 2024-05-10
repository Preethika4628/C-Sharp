using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaDiffShapes
{
    public class Rectangle : Dimension
    {
        public double Length {get; set;}
        public double Height {get; set;}
        public Rectangle(double value1, double value2, double area, double length, double height) : base( value1,  value2,  area)
        {
            Length = length;
            Height = height;
        }
        public override double Calculate()
        {
            Area = Length*Height;
            return Area;
        }
        public override double DisplayArea()
        {
            return Area;
        }
    }
}