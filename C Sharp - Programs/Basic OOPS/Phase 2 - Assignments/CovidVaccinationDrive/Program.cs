using System;
namespace CovidVaccinationDrive;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*****COVID VACCINATION DRIVE*****");
        Operation.AddDefaultData();
        Operation.MainMenu();
    }
}