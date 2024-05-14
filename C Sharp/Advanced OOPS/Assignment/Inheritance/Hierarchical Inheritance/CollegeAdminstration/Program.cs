using System;
using CollegeAdminstration;
namespace CollegeAdministration;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Preethi", "Sathish", new DateTime(2000, 11, 01), 987456314, "Female", "preethi@gmail.com", "CSE", "CS", 5);
        Console.WriteLine(student.ShowDetails());
        PrincipalInfo principal = new PrincipalInfo("Preethi", "Sathish", new DateTime(2000, 11, 01), 987456314, "Female", "preethi@gmail.com", "CSE", 7, new DateTime(2006, 05, 05));
        Console.WriteLine(principal.ShowDetails());
    }
}