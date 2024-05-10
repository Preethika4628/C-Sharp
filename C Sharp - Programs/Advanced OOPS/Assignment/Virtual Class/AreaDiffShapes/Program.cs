using System;
namespace AreaDiffShapes;
class Program
{
    public static void Main(string[] args)
    {
        Dimension dimension = new Dimension(5 , 7 , 0);
        Console.WriteLine(dimension.Calculate());
        Console.WriteLine(dimension.DisplayArea());
        Rectangle rectangle = new Rectangle(0,0,0, 14, 2);
        Console.WriteLine(rectangle.Calculate());
        Console.WriteLine(rectangle.DisplayArea());
            
    }
}