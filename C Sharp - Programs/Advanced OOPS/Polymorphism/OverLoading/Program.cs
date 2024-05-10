using System;
namespace OverLoading;
class Program 
{
    public static void Main(string[] args)
    {
        //overloading by arg
        Add(20, 30);
        Add(50,10,70);
        //overloading ny types
        Add("Preethi", 20);
        Add(10.5, 30);
    }
    public static int Add(int number1, int number2)
    {
        return number1+number2;
    }
    public static int Add(int number1, int number2, int number3)
    {
        return number1+ number2+ number3;
    }
    public static string Add(string name, int number1)
    {
        return name+number1;
    }
    public static double Add(double number1 , int number2)
    {
        return number1 + number2;
    }
}