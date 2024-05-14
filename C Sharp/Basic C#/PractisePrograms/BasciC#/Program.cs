using System;
using System.Diagnostics;
namespace Basic;
class Program
{
    public static void Main(string[] args)
    {
        // //Conversion of c to f and k
        // double celsius = double.Parse(Console.ReadLine());
        // double fahrenheit = celsius * 9/5 + 32;
        // double kelvin = celsius + 273.15;
        // Console.WriteLine(fahrenheit);
        // Console.WriteLine(kelvin);

        // //sum of digits
        // int num = int.Parse(Console.ReadLine());
        // int r1 = num % 10;
        // int r2 = num / 10;
        // int sum = r1+r2;
        // Console.WriteLine(sum);

        // //Calculate the total price - price + 18% tax
        // int price = int.Parse(Console.ReadLine());
        // int per = price * 18/100;
        // int total = price + per;
        // Console.WriteLine(total);

        // //Calculate the distance
        // double m = double.Parse(Console.ReadLine());
        // double s = double.Parse(Console.ReadLine());
        // double km = m / 1000;
        // double d = km;

        // //ternary operation
        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        // bool result = num1 <= num2 ? true : false;
        // Console.WriteLine(result);

        // //calculate sum, percent
        // double sum = double.Parse(Console.ReadLine());
        // sum = sum + double.Parse(Console.ReadLine());
        // sum = sum + double.Parse(Console.ReadLine());
        // Console.WriteLine("Sum:"+sum);
        // double Percentage = (sum/300) * 100;
        // Console.WriteLine("Percentage:"+Percentage);

        // //9.compare the inputs
        // int value1 = int.Parse(Console.ReadLine());
        // int value2 = int.Parse(Console.ReadLine());
        // Console.WriteLine(value1 > value2 ? "True" : "False");
        // Console.WriteLine(value1 < value2 ? "True" : "False");
        // Console.WriteLine(value1 >= value2 ? "True" : "False");
        // Console.WriteLine(value1 == value2 ? "True" : "False");
        // Console.WriteLine(value1 != value2 ? "True" : "False");
        // Console.WriteLine(value1 <= value2 ? "True" : "False");
        // Console.WriteLine(value1 >= 10 && value2 >= 10);
        // Console.WriteLine(value1 >= 10 || value2>=30);
        // Console.WriteLine(!(value1>20));

        //7.Distance travelled
        double seconds = double.Parse(Console.ReadLine());
        double km = double.Parse(Console.ReadLine());
        double temp = km * seconds;
        double distance = temp * 5/18;
        Console.WriteLine(distance);

    }
}
