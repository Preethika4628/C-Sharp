using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class PermanentEmployee : SalaryInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID {get; set;}
        public string EmployeeType {get; set;}
        public double DA {get; set;}
        public double HRA {get; set;}
        public double PF {get; set;}
        public double TotalSalary {get; set;}
        public PermanentEmployee(double basicSalary, DateTime month, string employeeType, double da, double hra, double pf, double totalSalary) : base (basicSalary, month)
        {
            s_employeeID++;
            EmployeeID = "EMP" + s_employeeID;
            EmployeeType = employeeType;
            DA = da;
            HRA = hra;
            PF = pf;
            TotalSalary = totalSalary;
        }
        public PermanentEmployee()
        {
            // s_employeeID++;
            // EmployeeID = "EMP" + s_employeeID;
        }

        public double CalculateTotalSalary(double BasicSalary)
        {
            DA = (0.2/100) * BasicSalary;
            HRA = (0.18/100) * BasicSalary;
            PF = (0.1/100) * BasicSalary;
            TotalSalary = BasicSalary + DA + HRA + PF;
            return TotalSalary;
        }
        public double ShowSalary()
        {
            return TotalSalary;
        }
    }
}