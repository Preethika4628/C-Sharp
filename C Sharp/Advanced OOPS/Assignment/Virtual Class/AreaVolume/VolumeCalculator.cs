using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaVolume
{
    public class VolumeCalculator : AreaCalculator
    {
        public int Height {get; set;}
        public VolumeCalculator(double radius, int height) : base(radius)
        {
            Height = height;
        }
        public override double Calculate(double pi)
        {
            double area = pi* Radius * Radius * Height;
            return area;
        }
        public override double Display(double area)
        {
            return area;
        }
    }
}