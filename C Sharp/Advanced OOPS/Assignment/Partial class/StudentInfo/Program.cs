using System;
namespace StudentInfo;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student  =new StudentInfo("Preethika", "Female", new DateTime(2000, 11, 01), 9874563215, 85, 75, 95);
        Console.WriteLine(student.Display());

    }
}