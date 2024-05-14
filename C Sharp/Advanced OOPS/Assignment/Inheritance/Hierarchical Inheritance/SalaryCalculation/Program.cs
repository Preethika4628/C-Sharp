using System;
namespace SalaryCalculation;
class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee permanent = new PermanentEmployee();
        TemporaryEmployee temporary = new TemporaryEmployee();
        Console.WriteLine("Choose: 1.Permanent employee  2.Temporary employee");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine("Enter your basic Salary");
                    double psalary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Salary calculation: "+permanent.CalculateTotalSalary(psalary));
                    Console.WriteLine("Total salary: "+ permanent.ShowSalary());
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Enter your basic Salary");
                    double tsalary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Salary calculation: " + temporary.CalculateTotalSalary(tsalary));
                    Console.WriteLine("Total salary: "+temporary.ShowSalary());
                    break;
                }
            default:
            {
                Console.WriteLine("Enter 1 or 2");
                break;
            }
        }





    }
}