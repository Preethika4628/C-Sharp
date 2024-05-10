using System;
using System.IO;

namespace SyncfusionAdmission
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("SyncfusionAdmission"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("SyncfusionAdmission");
            }
            //files for student details
            if(!File.Exists("SyncfusionAdmission/StudentDetails.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("SyncfusionAdmission/StudentDetails.csv").Close();
            }
            //file for department details
            if(!File.Exists("SyncfusionAdmission/DepartmentDetails.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("SyncfusionAdmission/DepartmentDetails.csv").Close();
            }
            //file for admission details
            if(!File.Exists("SyncfusionAdmission/AdmissionDetails.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("SyncfusionAdmission/AdmissionDetails.csv").Close();
            }
        }
        public static void WriteToCSV()
        {
            //students details
            string[] students = new string[Operations.studentList.Count];
            for(int i=0; i<Operations.studentList.Count; i++)
            {
                students[i] = Operations.studentList[i].StudentID + "," + Operations.studentList[i].StudentName + "," + Operations.studentList[i].FatherName + "," + Operations.studentList[i].DOB.ToString("dd/MM/yyyy") + "," + Operations.studentList[i].Gender + "," + Operations.studentList[i].Physics + "," + Operations.studentList[i].Chemistry + "," + Operations.studentList[i].Maths;
            }
            File.WriteAllLines("SyncfusionAdmission/StudentDetails.csv", students);

            //department details
            string[] department = new string[Operations.departmentList.Count];
            for(int i=0; i<Operations.departmentList.Count; i++)
            {
                department[i] = Operations.departmentList[i].DepartmentID + "," + Operations.departmentList[i].DepartmentName + "," +Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("SyncfusionAdmission/DepartmentDetails.csv", department);

            //admission details
            string[] admission = new string[Operations.admissionList.Count];
            for(int i=0; i<Operations.admissionList.Count; i++)
            {
                admission[i] = Operations.admissionList[i].AdmissionID + "," + Operations.admissionList[i].StudentID + "," + Operations.admissionList[i].DepartmentID + "," + Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy") + "," + Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("SyncfusionAdmission/AdmissionDetails.csv", admission);
        }
        public static void ReadFromCSV()
        {
            string[] students = File.ReadAllLines("SyncfusionAdmission/StudentDetails.csv");
            foreach(string student in students)
            {
                StudentDetails student1 = new StudentDetails(student);
                Operations.studentList.Add(student1);
            }

            string[] departments = File.ReadAllLines("SyncfusionAdmission/DepartmentDetails.csv");
            foreach(string department in departments)
            {
                DepartmentDetails department1 = new DepartmentDetails(department);
                Operations.departmentList.Add(department1);
            }

            string[] admissions = File.ReadAllLines("SyncfusionAdmission/AdmissionDetails.csv");
            foreach(string admission in admissions)
            {
                AdmissionDetails admission1 = new AdmissionDetails(admission);
                Operations.admissionList.Add(admission1);
            }
        }
    }
}