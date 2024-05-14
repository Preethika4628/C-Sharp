using System;
namespace Cafeteria;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****CAFETERIA CARD MANAGEMENT*****");
        FileHandling.Create();
        // Operation.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operation.MainMenu();
        FileHandling.WriteToCSV();
    }
}