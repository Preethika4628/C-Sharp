using System;
namespace CollegeStudentAdmission
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 101;
        public string DepartmentID { get; }
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }

        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            s_departmentID++;
            DepartmentID = "DID" + s_departmentID;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }

    }
}
