using System;
namespace SyncCart;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****E-COMMERCE APPLICATION - SYNCCART*****");
        Operation.AddDefaultData();
        Operation.MainMenu();
    }
}