using System;
namespace BloodBank;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****BLOOD BANK MANAGEMENT SYSTEM*****");
        Operation.AddDefaultData();
        Operation.MainMenu();
    }
}