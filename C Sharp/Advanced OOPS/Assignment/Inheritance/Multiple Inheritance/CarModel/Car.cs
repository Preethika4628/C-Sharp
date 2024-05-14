using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car
    {
        public string FuelType {get; set;}
        public int NumberOfSeats {get; set;}
        public string Color {get; set;}
        public double TankCapacity {get; set;}
        public double NumberOfKmDriven {get; set;}
        public Car(string fuelType, int numberOfSeats, string color, double numberOfKmDriven, double tankCapacity)
        {
            FuelType = fuelType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
        public double CalculateMilage(double numberOfKmDriven, double tankCapacity)
        {
            double mileage = NumberOfKmDriven / TankCapacity;
            return mileage;
        }
    }
}