using System;
namespace DoWhileArg;
class Program
{
    public static void Main(string[] args)
    {
        string option = "";
        double num1, num2;
        do
        {
            Console.Write("Enter a first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose one of the operation from below: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the option number you needed: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    double sum = add(num1,num2);
                    Console.WriteLine("Sum is: " + sum);
                    break;
                case 2:
                    double difference = sub(num1,num2);
                    Console.WriteLine("Difference is: " + difference);
                    break;
                case 3:
                    double product = mul(num1,num2);
                    Console.WriteLine("Product is: " + product);
                    break;
                case 4:
                    double quotient = div(num1,num2);
                    Console.WriteLine("Quotient is: " + quotient);
                    break;
                default:
                    Console.WriteLine("Invalid Input, Choose only from the options below");
                    break;
            }

            //yes or no
            while(true)
            {
                Console.WriteLine("Whether to repeat the process with another number? yes / no");
                option = Console.ReadLine();
                if(option.ToLower()=="yes" || option.ToLower()=="no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid, Only valid input is accepted");
                    Console.WriteLine();
                }
            }
        }while(option == "yes");
    }

    static double add(double a, double b)
    {
        double c = a + b;
        return c;
    }
    static double sub(double a, double b)
    {
        double c = a - b;
        return c;
    }
    static double mul(double a, double b)
    {
        double c = a * b;
        return c;
    }
    static double div(double a, double b)
    {
        double c = a / b;
        return c;
    }
}