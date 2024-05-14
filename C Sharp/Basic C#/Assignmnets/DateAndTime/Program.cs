using System;
namespace DateAndTime;
class Program 
{
    public static void Main(string[] args)
    {
        //Question 1:
        DateTime data = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(data.Year);
        Console.WriteLine(data.Month);
        Console.WriteLine(data.Day);
        Console.WriteLine(data.Hour);
        Console.WriteLine(data.Minute);
        Console.WriteLine(data.Second);

        //Question 2:
        // Console.WriteLine("Enter a date in yyyy/mm/dd hh:mm:ss format: ");
        DateTime newDate = new DateTime(2007,9,9,10,10,39);
        Console.WriteLine(newDate);
        string s1= newDate.ToString("tt ss:mm:hh yyyy/mm/dd");
        Console.WriteLine(newDate.ToString("tt ss:mm:hh yyyy/mm/dd"));
        string[] SnewDate = s1.Split(',',' ',':','/');
        foreach (string revString in SnewDate)
        {
            Console.Write(revString + " ");
        }
        Console.WriteLine();

        //Question 3:
        Console.Write("Enter a date in yyyy/mm/d hh:mm:ss tt  format- ");
        DateTime dob = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(dob.Year);
        Console.WriteLine(dob.Month);
        Console.WriteLine(dob.Day);
    }

}