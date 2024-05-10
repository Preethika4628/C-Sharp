using System;
namespace OverRiding;
class Program 
{
    public static void Main(string[] args)
    {
        
        Pomerian pomerian = new Pomerian();
        Console.WriteLine(pomerian.Sound());
        Animal animal = new Pomerian();
        Console.WriteLine(animal.Sound());
    }
}