using System;
using System.Collections.Generic;
namespace EmployeePayRoll;
class Program 
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
        int n;

        do
        {
            Console.WriteLine(" EMPLOYEE PAYROLL MANAGEMENT ");
            Console.WriteLine(" Choose:  1.Registration  2.Login  3.Exit");
            n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:
                    string option = "";
                    do
                    {
                        Console.WriteLine("REGISTRATION FORM:");
                        Console.Write("Enter your name: ");
                        string employeeName = Console.ReadLine();
                        Console.Write("Enter your role: ");
                        string role = Console.ReadLine();
                        Console.Write("Enter your location: ");
                        WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(), true);
                        Console.Write("Enter your Team Name: ");
                        string teamName = Console.ReadLine();
                        Console.Write("Enter your date of joining: ");
                        DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.Write("Enter number of days taken leave: ");
                        int numLeave = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of working days in a month: ");
                        int numWork = int.Parse(Console.ReadLine());
                        Console.Write("Enter your Gender: ");
                        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

                        EmployeeDetails employee = new EmployeeDetails(employeeName, role, workLocation, teamName, doj, numWork,numLeave, gender);
                        Console.WriteLine("**You have registered successfully**");
                        Console.WriteLine("Your Employee ID is "+ employee.EmployeeID);
                        employeeList.Add(employee);
                        Console.WriteLine("Do you want to continue? ");
                        option = Console.ReadLine();

                    }while(option == "yes");
                    break;
                case 2:
                    Console.WriteLine("LOGIN:");
                    Console.Write("Enter your EmployeeID: ");
                    string empID = Console.ReadLine();

                    foreach(EmployeeDetails i in employeeList)
                    {
                        bool flag = true;
                        if(i.EmployeeID == empID)
                        {
                            Console.WriteLine("Welcome " + i.EmployeeName);
                            Console.WriteLine("Choose: \n1. Calculate Salary \n2.Employee Details \n3.Exit");
                            int input = int.Parse(Console.ReadLine());
                            switch(input)
                            {
                                case 1:
                                    Console.WriteLine("Employee Salary");
                                    Console.WriteLine("Employee Name: " + i.EmployeeName);
                                    double salary  = i.CalculateSalary();
                                    Console.WriteLine("Total Salary: " + salary);
                                    break;
                                case 2:
                                    Console.WriteLine("Employee Details");
                                    Console.WriteLine("Employee Name: " + i.EmployeeName);
                                    Console.WriteLine("Role: " + i.Role);
                                    Console.WriteLine("WorkLocation: " + i.WorkLocation);
                                    Console.WriteLine("Team Name: " + i.TeamName);
                                    Console.WriteLine("Date of Joining: " + i.DOJ);
                                    Console.WriteLine("Number of working days in month: " + i.NumWorkDays);
                                    Console.WriteLine("Number of days leave: " + i.NumLeave);
                                    Console.WriteLine("Gender: " + i.Gender);
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("This EmployeeID does not exist");
                        }
                        if(flag)
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }
                }
                break;
            case 3:
                break;
            }
        }while(n != 3);
    }
}