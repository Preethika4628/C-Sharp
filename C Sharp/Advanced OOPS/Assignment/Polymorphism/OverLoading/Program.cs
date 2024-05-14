using System;
namespace OverLoading;
class Program 
{
    public static void Main(string[] args)
    {
        Square(10);
        Square(30, 50);

    }
    public static void Square(int num1)
    {
        Console.WriteLine(num1 * num1);
    }
    public static void Square(int num1, int num2)
    {
        Console.WriteLine(num1 * num2);
    }
}