using System;
namespace Person;
class Program 
{
    public static void Main(string[] args)
    {
        RegisterPerson person = new RegisterPerson("Preethi", Gender.Female, new DateTime(200,11,01), 9874563212, Marital.Single, "Sathish", "Deepa", "Virudhunagar", 2, DateTime.Now);
        Console.WriteLine(person.ShowInfo());
    }
}