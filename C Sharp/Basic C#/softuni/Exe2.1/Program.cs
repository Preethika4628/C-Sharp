using System;
namespace Exe21;
class Program
{
    public static void Main(string[] args)
    {
        //square of a number
        //inches to cm
        //greeting by name
        //concatenating text and numbers
        //trapezoid area
        //Area and Perimeter of a circle
        //rectangle are
        //triangle area
        //celcius to fareheit
        //radians to degree

        // //square of a number
        // int a = int.Parse(Console.ReadLine());
        // int area = a*a;
        // Console.WriteLine("Area= " + area);

        // //inches to centimeter
        // double inches = int.Parse(Console.ReadLine());
        // double cm = inches*2.54;
        // Console.WriteLine("Centimeter= " + cm);

        // //greeting by name
        // string name = Console.ReadLine();
        // Console.WriteLine("Hello, {0}!",name);

        // //concatenating text and numbers
        // string firstname = Console.ReadLine();
        // string lastname = Console.ReadLine();
        // int age = int.Parse(Console.ReadLine());
        // string town = Console.ReadLine();
        // Console.WriteLine("You are {0} {1}, a {2}-years old from {3}", firstname, lastname, age, town);

        // //trapezoid area
        // double b1 = double.Parse(Console.ReadLine());
        // double b2 = double.Parse(Console.ReadLine());
        // double h = double.Parse(Console.ReadLine());
        // double area = (b1 + b2)+h/2;
        // Console.WriteLine("Trapezoid area = {0}",area);

        // //Area and Perimeter of a circle
        // double r = double.Parse(Console.ReadLine());
        // double area = 3.14*r*r;
        // double perimeter = 2*3.14*r;
        // Console.WriteLine("Area = {0}", area);
        // Console.WriteLine("Perimater = {0}", perimeter);

        // //rectangle area
        // int x1 = int.Parse(Console.ReadLine());
        // int y1 = int.Parse(Console.ReadLine());
        // int x2 = int.Parse(Console.ReadLine());
        // int y2 = int.Parse(Console.ReadLine());
        // int area = (x1-x2) * (y2-y1);
        // int perimeter = 2 * ((x1-x2) + (y2-y1));
        // Console.WriteLine(area);
        // Console.WriteLine(perimeter);

        // //triangle area
        // double a = double.Parse(Console.ReadLine());
        // double h = double.Parse(Console.ReadLine());
        // double area = a * h/2;
        // Console.WriteLine(Math.Round(area, 2));

        // //celcius to farenheit
        // double c = double.Parse(Console.ReadLine());
        // double f = (c*9/5)+32;
        // Console.WriteLine(f);

        // //radians to degree
        // double r = double.Parse(Console.ReadLine());
        // double d = r * 180/3.14;
        // Console.WriteLine(d);

        //USD to bulgarian
        double usd = double.Parse(Console.ReadLine());
        double bulgarian = usd * 1.79549;
        Console.WriteLine(Math.Round(bulgarian, 2));

    }
}