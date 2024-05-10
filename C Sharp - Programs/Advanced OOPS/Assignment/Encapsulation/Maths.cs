using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double PI = 3.14;
        internal double G = 9.8;
        public Maths(double pi, double g)
        {
            PI = pi;
            G = g;
        }
        public Maths()
        {

        }
        public double Calculateweight(int weight)
        {
            double totalWeight = weight*G;
            return totalWeight;
        }
    }
}