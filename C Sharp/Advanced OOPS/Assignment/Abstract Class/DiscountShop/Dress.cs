using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountShop
{
    public abstract class Dress
    {
        public abstract string DressType {get; set;}
        public abstract string Dressname {get; set;}
        public abstract double Price {get; set;}
        public abstract double TotalPrice {get; set;}
        public abstract string Getdressinfo();
        public abstract string DisplayInfo();
    }
}