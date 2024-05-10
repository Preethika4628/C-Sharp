using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaDiffShapes
{
    public class Dimension
    {
        public double Value1 {get; set;}
        public double Value2 {get; set;}
        public double Area {get; set;}
        public Dimension(double value1, double value2, double area)
        {
            Value1 = value1;
            Value2 = value2;
            Area = area;
        }
        public virtual double Calculate()
        {
            Area = Value1*Value2;
            return Area;
        }
        public virtual double DisplayArea()
        {
            return Area;
        }
    }
}