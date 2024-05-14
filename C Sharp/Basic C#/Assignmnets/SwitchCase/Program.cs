using System;
namespace SwitchCase;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose any one of the below operations: ");
        Console.WriteLine("For Addition, press + key");
        Console.WriteLine("For Subtraction, press - key");
        Console.WriteLine("For Multiplication, press * key");
        Console.WriteLine("For Division, press / key");
        Console.WriteLine("For Modulo division, press % key");
        char operation = char.Parse(Console.ReadLine());

        switch(operation)
        {
            case '+':
                double a = num1 + num2;
                Console.Write("Added value is: " + a);
                break;
            case '-':
                double b = num1 - num2;
                Console.Write("Subtracted value is: " + b);
                break;
            case '*':
                double c = num1 * num2;
                Console.Write("Multiplied value is: " + c);
                break;
            case '/':
                double d = num1 / num2;
                Console.Write("Divded value is: " + d);
                break;
            case '%':
                double e = num1 % num2;
                Console.Write("Modulo divided value is: " + e);
                break;
            default:
                Console.WriteLine("Invalid Input, Choose only from the options below");
                break;
        }
    }
}