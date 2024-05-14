using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiffShapes
{
    public abstract class Shape
    {
        public abstract double Area {get; set;}
        public abstract double Volume {get; set;}
        public double Radius {get; set;}
        public double Height {get; set;}
        public double Width {get; set;}
        public double A {get; set;} 
        // public Shape(double area, double volume, double radius, double height, double width, double a)
        // {
        //     Area = area;
        //     Volume = volume;
        //     Radius = radius;
        //     Height = height;
        //     Width = width;
        //     A = a;
        // }
        public Shape()
        {

        }

        public Shape(double area, double volume)
        {
            Area = area;
            Volume = volume;
        }
        public abstract double CalculateArea();
        public abstract double CalculateVolume();
    }
}