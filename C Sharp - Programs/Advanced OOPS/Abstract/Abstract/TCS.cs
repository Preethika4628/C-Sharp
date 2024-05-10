using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class TCS : Salary
    {
        public override string CompanyName { get; set; }
        public TCS(string employeeID, string employeeName, string comapanyName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            CompanyName = comapanyName;
        }
        public override void CalculateSalary(int Days, double salaryPerDay )
        {
            double salary = Days * salaryPerDay;
            TotalSalary = 0.18 * salary + salary;
        }

    }
}