using System;
namespace AreaVolume;
class Program 
{
    public static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());
        AreaCalculator area = new AreaCalculator(radius);
        Console.WriteLine(area.Calculate(3.14));
        VolumeCalculator volume = new VolumeCalculator(radius, 8);
        Console.WriteLine(volume.Calculate(3.14));
        double totalArea = volume.Calculate(3.14);
        Console.WriteLine(volume.Display(totalArea));
    }
}