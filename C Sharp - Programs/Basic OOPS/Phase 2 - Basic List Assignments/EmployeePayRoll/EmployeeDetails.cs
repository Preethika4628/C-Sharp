using System;
namespace EmployeePayRoll
{
    public enum Gender
    {
        Male, Female
    }
    public enum WorkLocation
    {
        Chennai, USA, Kenya
    }
    public class EmployeeDetails
    {
        private static int s_employeeID = 1001;
        public string EmployeeID { get; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DOJ { get; set; }
        public int NumWorkDays { get; set; }
        public int NumLeave { get; set; }
        public Gender Gender { get; set; }

        public EmployeeDetails( string employeeName, string role, WorkLocation workLocation, string teamName, 
            DateTime doj, int numWork, int numLeave, Gender gender)
        {
            s_employeeID++;
            EmployeeID = "SF" + s_employeeID;
            EmployeeName = employeeName;
            Role = role;
            WorkLocation = workLocation;
            TeamName = teamName;
            DOJ = doj;
            NumWorkDays = numWork;
            NumLeave = numLeave;
            Gender = gender;
        }

        public double CalculateSalary()
        {
            return (NumWorkDays-NumLeave) * 500;
        }
    }
}