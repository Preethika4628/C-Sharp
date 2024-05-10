using System;
using System.Collections.Generic;
using System.Linq;
namespace Excerise2;
class Program 
{
    public static void Main(string[] args)
    {
        // to display the list of items in the array according to the length of the string then by name in ascending order.
        string[] cities = {"ABU DHABI", "AMSTERDAM", "ROME", "MADURAI", "LONDON", "NEW DELHI", "MUMBAI", "NAIROBI"};
        IEnumerable<string> result = cities.OrderBy(city => city.Length).ThenBy(city => city);
        foreach(string city in result)
        {
            Console.WriteLine(city);
        }
    }
}