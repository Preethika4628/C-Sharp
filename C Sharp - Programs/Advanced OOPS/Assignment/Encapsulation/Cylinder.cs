using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Cylinder
    {
        private double _height;
        public double Height {get { return _height;}}
        internal double Volume {get; set;}
        public Cylinder(double pi, double g, int radius, double area, double height)
        {
            _height = height;
        }
        public Cylinder()
        {

        }
        public double CalculateVloume(double Area, double height)
        {
            double totalArea = Area * height;
            return totalArea;
        }
    }
}