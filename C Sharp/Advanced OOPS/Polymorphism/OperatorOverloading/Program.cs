using System;
namespace OperatorOverloading;
class Program 
{
    public static void Main(string[] args)
    {
        Box box = new Box(10, 20, 30);
        Box box1 = new Box(10, 20, 30);
        Console.WriteLine(box.CalculateVolume());
        Console.WriteLine(box1.CalculateVolume());
        Box box2 = box + box1;
    }
}