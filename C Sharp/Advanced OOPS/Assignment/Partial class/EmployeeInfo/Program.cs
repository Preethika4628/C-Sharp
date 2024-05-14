using System;
namespace EmployeeInfo;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Preethika", "Female");
        employee.Display();
    }
}