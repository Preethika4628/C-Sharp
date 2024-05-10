using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the two numbers between which the sum of the squares of the numbers need to be calculated:");
        Console.Write("Enter Lower limit value: ");
        double lowerLimit = double.Parse(Console.ReadLine());
        Console.Write("Enter Upper limit value: ");
        double upperLimit = double.Parse(Console.ReadLine());
        double sum = 0;

        for(double i = lowerLimit+1 ; i < upperLimit ; i++ )
        {
            sum = sum + (i*i);
        }
        Console.WriteLine("Sum of the square of the number between the given limits: " + sum);
    }
}