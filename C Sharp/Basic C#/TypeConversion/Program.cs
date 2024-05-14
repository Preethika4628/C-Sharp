using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("Total is: " + sum);

        Console.Write("Enter a double number: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.Write("Enter another double number: ");
        double num4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Number is: " + num3);
        Console.WriteLine("Number is: " + num4);

        int Num1 = Convert.ToInt32(null);
        Console.WriteLine(Num1);
        int Num2 = int.Parse(null);
        Console.WriteLine(Num2);
    }
}