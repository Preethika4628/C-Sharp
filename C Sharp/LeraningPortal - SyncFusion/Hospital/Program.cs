using System;
namespace Hospital;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***Hospital Management***");
        Operations.AddingDefaultData();
        Operations.MainMenu();
    }
}