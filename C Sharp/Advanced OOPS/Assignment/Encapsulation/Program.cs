using System;
using CalculatorApp;
namespace Encapsulation;
class Program 
{
    public static void Main(string[] args)
    {
        CircleArea area = new CircleArea();
        var Area = area.CalcualteCircle(5);
        Console.WriteLine(Area);
        Cylinder cylinder = new Cylinder();
        Console.WriteLine(cylinder.CalculateVloume(Area, 6));


    }
}