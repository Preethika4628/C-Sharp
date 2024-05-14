using System;
using MultipleInhertiance;
namespace MultipleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo personal = new PersonalInfo("Preethika", Gender.Female, new DateTime(2000, 11, 01), 9874563215, Marital.Single);
        Console.WriteLine(personal.ShowInfo());
        RegisterPerson register = new RegisterPerson("Preethika", Gender.Female, new DateTime(2000, 11, 01), 9874563215, Marital.Single, "Sathish", "Deepa", "Virudhunagar", 2, DateTime.Now);
        Console.WriteLine(register.ShowInfo());
    }
}