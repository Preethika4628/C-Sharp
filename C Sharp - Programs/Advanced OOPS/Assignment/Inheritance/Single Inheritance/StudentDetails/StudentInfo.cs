using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class StudentInfo : PersonalInfo
    {
        public int RegisterNumber {get; set;}
        public string Standard {get; set;}
        public string Branch {get; set;}
        public int AcademicYear {get; set;}
        public StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender, int registerNumber, string standard, string branch, int academicYear)
            : base(name, fatherName, phone, mail, dob, gender)
        {
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"{Name} | {FatherName} | {Phone} | {Mail} | {DOB.ToString("dd/MM/yyyy")} | {Gender} | {RegisterNumber} | {Standard} | {Branch} | {AcademicYear}");
        }

    }
}