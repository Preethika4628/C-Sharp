using System;
namespace CarModel;
class Program 
{
    public static void Main(string[] args)
    {
        ShiftDezire dezire = new ShiftDezire("Petrol", 6, "Black", 200, 50, 9823, 6541, "Swift", "A105");
        Console.WriteLine(dezire.ShowDetails());
        Eco eco = new Eco("Diesel", 7, "Grey", 500, 150, 4196, 5286, "Swift", "D250");
        Console.WriteLine(eco.ShowDetails());
    }
}