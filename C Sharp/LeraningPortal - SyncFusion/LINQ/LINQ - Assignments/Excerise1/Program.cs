using System;
using System.Linq;
namespace Excerise1;
class Program 
{
    public static void Main(string[] args)
    {
        // to find the string which starts and ends with a specific character.
        string[] cities = {"ABU DHABI", "AMSTERDAM", "ROME", "MADURAI", "LONDON", "NEW DELHI", "MUMBAI", "NAIROBI"};
        Console.Write("Enter the starting character of the string: ");
        string start = Console.ReadLine();
        Console.Write("Enter the ending character of the string: ");
        string end = Console.ReadLine();
        var result = from city in cities where city.StartsWith(start) where city.EndsWith(end) select city;
        Console.Write($"The city starting with {start} and ending with {end} is: ");
        foreach(var city in result)
        {
            Console.Write(city + " ");
        }

        

    }
}