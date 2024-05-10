using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class Syncfusion : Salary
    {
        public override string CompanyName { get; set; }
        public Syncfusion(string employeeID, string employeeName, string comapanyName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            CompanyName = comapanyName;
        }
        public override void CalculateSalary(int Days, double salaryPerDay )
        {
            double salary = Days * salaryPerDay;
            TotalSalary = 0.10 * salary + salary;
        }

    }
}