using System;
namespace Student;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("SID1000", "Sha", "Sathish", 9874563215);
        student.Display();

        EmployeeInfo employee = new EmployeeInfo("SF4628", "Sri", "Shathish");
        employee.Display();

        
    }
    interface IDisplayInfo
    {
        void Display();
    }
    class StudentInfo : IDisplayInfo
    {
        public string StudentID {get; set;}
        public string Name {get; set;}
        public string FatherName {get; set;}
        public long MobileNumber {get; set;}
        public StudentInfo(string studentID, string name, string fathername, long mobile)
        {
            StudentID = studentID;
            Name = name;
            FatherName = fathername;
            MobileNumber = mobile;
    
        }
        public void Display()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine(" Student ID: " + StudentID);
            Console.WriteLine(" Name: " + Name);
            Console.WriteLine(" Father Name: " + FatherName);
            Console.WriteLine(" Mobile Number: " + MobileNumber);
        }
    }
    class EmployeeInfo : IDisplayInfo
    {
        public string EmployeeID {get; set;}
        public string Name {get; set;}
        public string FatherName {get; set;}
        public EmployeeInfo(string employeeID, string name, string fathername)
        {
            EmployeeID = employeeID;
            Name = name;
            FatherName = fathername;
    
        }
        public void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine(" Student ID: " + EmployeeID);
            Console.WriteLine(" Name: " + Name);
            Console.WriteLine(" Father Name: " + FatherName);
        }
    }
}