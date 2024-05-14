using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected int _radius;
        public int Radius {get {return _radius;}}
        internal double Area {get; set;}
        public CircleArea(double pi, double g, int radius, double area) : base(pi, g)
        {
            _radius = radius;
            Area = area;
        }
        public CircleArea()
        {

        }
        public double CalcualteCircle(double radius)
        {
            Area = PI* (radius* radius);
            return Area;

        }
    }
}