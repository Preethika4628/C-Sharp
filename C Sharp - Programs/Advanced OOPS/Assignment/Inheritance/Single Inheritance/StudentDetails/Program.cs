using System;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Preethika", "Sathish", 9876543215, "preethi@gmail.com", new DateTime(2000, 11, 01), Gender.Female, 4628, "12th", "CS", 2020);
        student.ShowStudentInfo();
    }
}