using System;
namespace Demo;
public enum Gender
{
    Select, Male, Female, TransGender
}
class Program
{
    public static void Main(string[] args)
    {
        // Gender gender = 0;
        // Console.Write("Select your gender: 1.Male 2.Female 3.Transgender");
        // int genderValue = int.Parse(Console.ReadLine());
        // gender = (Gender)genderValue;

        Gender gender;
        Console.Write("Select your gender: 1.Male 2.Female 3.Transgender");
        bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
        while (!temp)
        {
            Console.WriteLine("Invalid gender value. Type again");
            temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
        }

        Console.Write("Select your gender: 1.Male 2.Female 3.Transgender");
        int genderValue = int.Parse(Console.ReadLine());
        gender = (Gender)genderValue;
        switch(gender)
        {
            case Gender.Male:
            {
                Console.WriteLine("Male");
                break;
            }
            case Gender.Female:
            {
                Console.WriteLine("Female");
                break;
            }
        }
    }
}