using System;
namespace BloodBank;
class Program 
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        Console.WriteLine("*****BLOOD BANK MANAGEMENT SYSTEM*****");
        // Operation.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operation.MainMenu();
        FileHandling.WriteToCSV();
    }
}