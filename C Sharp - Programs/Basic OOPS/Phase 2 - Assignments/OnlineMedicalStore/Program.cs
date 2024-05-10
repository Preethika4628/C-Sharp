using System;
namespace OnlineMedicalStore;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****WELCOME TO MEDICAL STORE*****");
        Operation.AddDefaultData();
        Operation.MainMenu();
    }
}