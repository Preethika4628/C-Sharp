using System;
namespace SyncStays;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("****SYNC STAYS - HOTEL MANAGEMENT****");
        FileHandling.Create();
        // Operations.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operations.MainMenu();
        FileHandling.WritetoCSV();
    }
}