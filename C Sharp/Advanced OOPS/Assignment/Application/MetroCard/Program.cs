using System;
namespace MetroCard;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****METRO CARD MANAGEMENT*****");
        FileHandling.Create();
        // Operations.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}