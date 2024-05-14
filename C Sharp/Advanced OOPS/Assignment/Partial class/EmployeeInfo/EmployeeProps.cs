using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID {get; set;}
        public string Name {get; set;}
        public string Gender {get; set;}
    }
}