using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountShop
{
    public class LadiesWear : Dress
    {
        public override string DressType {get; set;}
        public override string Dressname {get; set;}
        public override double Price {get; set;}
        public override double TotalPrice {get; set;}
        public LadiesWear(string dressType, string dressName, double price, double totalPrice)
        {
            DressType = dressType;
            Dressname = dressName;
            Price = price;
            TotalPrice = totalPrice;
        }
    }
}