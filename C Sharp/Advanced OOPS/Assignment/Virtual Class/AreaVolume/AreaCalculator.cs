using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaVolume
{
    public class AreaCalculator
    {
        public double Radius {get; set;}
        public AreaCalculator(double radius)
        {
            Radius = radius;
        }
        public virtual double Calculate(double pi)
        {
            double area = pi* Radius * Radius;
            return area;
        }
        public virtual double Display(double area)
        {
            return area;
        }
    }
}