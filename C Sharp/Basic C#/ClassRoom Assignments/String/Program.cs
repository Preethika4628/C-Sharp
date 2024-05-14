using System;
using System.Threading;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Main String: ");
        string MainString = Console.ReadLine();
        string SubString = MainString.Substring(1, 2 );
        Console.WriteLine("Sub String: " + SubString);
        string[] temp = MainString.Split(SubString);
        int count = temp.Length-1;
        Console.WriteLine("Count value: " + count);
    }
}