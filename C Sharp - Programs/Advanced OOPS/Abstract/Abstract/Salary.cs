using System;

namespace Abstract
{
    //partial abstraction
    public abstract class Salary
    {
        //never static
        //field may be
        //normal and abstract prop avail
        //no constructor
        //normal and abstract method avail
        //can be used only with inheritance
        public string EmployeeID {get; set;}
        public string EmployeeName {get; set;}
        public abstract string CompanyName {get; set;}
        public double TotalSalary {get; set;}
        public abstract void CalculateSalary(int Days, double salaryPerDay);
    }

}