using System;
using System.Xml.Schema;
namespace TypeConversions;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        float mark1 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        float mark2 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        float mark3 = float.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        double mobile = double.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mail = Console.ReadLine();
        Console.WriteLine();

        float total = mark1 + mark2 + mark3;
        float average = total / 3;

        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: "+ age);
        Console.WriteLine("Mobile: " + mobile);
        Console.WriteLine("Marks1: " + mark1);
        Console.WriteLine("Marks2: " + mark2);
        Console.WriteLine("Marks3: " + mark3);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Mail id: " + mail);

    }
}