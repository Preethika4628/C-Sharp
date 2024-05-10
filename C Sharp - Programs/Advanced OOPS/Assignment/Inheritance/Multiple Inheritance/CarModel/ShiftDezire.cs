using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel 
{
    public class ShiftDezire : Car, IBrand
    {
        private static int s_makingID = 1000;
        public string MakingID {get; set;}
        public int EngineNumber {get; set;}
        public int ChasisNumber {get; set;}
        public string BrandName {get; set;}
        public string ModelName {get; set;}
        public ShiftDezire(string fuelType, int numberOfSeats, string color, double numberOfKmDriven, double tankCapacity, int engineNumber, int chasisNumber, string brandName, string modelName) : base(fuelType, numberOfSeats, color, numberOfKmDriven, tankCapacity)
        {
            s_makingID++;
            MakingID = "MID" + s_makingID;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName = modelName;
        }
        public string ShowDetails()
        {
            return ($"{MakingID}  |  {EngineNumber}  |  {ChasisNumber}  |  {BrandName}  |  {ModelName}");
        }
    }
}