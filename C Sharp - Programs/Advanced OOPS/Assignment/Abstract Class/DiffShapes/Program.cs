using System;
namespace DiffShapes;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter radius: ");
        int radius = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter length of the cube: ");
        int a = int.Parse(Console.ReadLine());

        Cylinders cylinders = new Cylinders(radius, height, width);
        Cubes cubes = new Cubes(a);

        Console.WriteLine(cylinders.CalculateArea());
        Console.WriteLine(cylinders.CalculateVolume());
        Console.WriteLine(cubes.CalculateArea());
        Console.WriteLine(cubes.CalculateVolume());

    }
}