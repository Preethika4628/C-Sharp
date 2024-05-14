using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        if (r > 0)
        {
            double c = 2 * Math.PI * r;
            Console.WriteLine(Math.Round(c,2));
        }
        else if (r < 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}