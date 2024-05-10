using System;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        //Getting the inputs
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();  //Read - for int
        Console.Write("Enter your father's name: ");
        string fatherName = Console.ReadLine();

        //Printing the results

        //basic printing
        Console.WriteLine(name);
        Console.WriteLine(fatherName);

        //concatenation
        Console.WriteLine(name +" "+ fatherName);

        //placeholder
        Console.WriteLine("{0} {1}", name, fatherName);
        Console.WriteLine("{0} {1}", fatherName, name);
        Console.WriteLine("{1} {0}", name, fatherName);

        //interpolation
        Console.WriteLine($"{name} {fatherName}"); //less runtime
        Console.ReadKey();
    }
}