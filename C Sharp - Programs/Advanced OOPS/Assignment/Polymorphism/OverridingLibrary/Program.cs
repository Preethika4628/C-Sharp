using System;
namespace OverridingLibrary;
class Program 
{
    public static void Main(string[] args)
    {
        EEEDepartment eee = new EEEDepartment("Shankar", "Book for Life", "Shakthi", DateTime.Today);
        Console.WriteLine(eee.SetBookInfo());
        CSEDepartment cse = new CSEDepartment("Dhivya", "Life Lessons", "ABC", DateTime.Now);
        Console.WriteLine(cse.DisplayInfo());
    }
}