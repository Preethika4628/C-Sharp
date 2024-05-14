using System;
namespace SyncfusionAdmission;
class Program 
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        Console.WriteLine("*****SYNCFUSION COLLEGE OF ENGINEERING AND TECHNOLOGY*****");
        // Operations.AddDefaultData();
        FileHandling.ReadFromCSV();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}