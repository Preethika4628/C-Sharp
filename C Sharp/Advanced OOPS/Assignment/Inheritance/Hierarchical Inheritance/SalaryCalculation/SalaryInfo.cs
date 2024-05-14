using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class SalaryInfo
    {
        public double BasicSalary {get; set;}
        public DateTime Month {get; set;}
        public SalaryInfo(double basicSalary, DateTime month)
        {
            BasicSalary = basicSalary;
            Month = month;
        }
        public SalaryInfo()
        {
            
        }

    }
}