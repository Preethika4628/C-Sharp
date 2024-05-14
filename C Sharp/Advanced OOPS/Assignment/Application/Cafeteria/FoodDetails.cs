using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class FoodDetails
    {
        private static int s_foodID = 100;
        public string FoodID {get; set;}
        public string FoodName {get; set;}
        public double Price {get; set;}
        public int AvailableQuantity {get; set;}

        public FoodDetails(string foodName, double price, int availableQuantity)
        {
            s_foodID++;
            FoodID = "FID" + s_foodID;
            FoodName = foodName;
            Price = price;
            AvailableQuantity = availableQuantity;
        }
        public FoodDetails(string food)
        {
            string[] values = food.Split(",");
            s_foodID = int.Parse(values[0].Remove(0,3));
            FoodID = values[0];
            FoodName = values[1];
            Price = double.Parse(values[2]);
            AvailableQuantity = int.Parse(values[3]);
        }

    }
}